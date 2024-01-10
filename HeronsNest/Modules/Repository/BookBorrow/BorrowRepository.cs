using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules.Response;
using Microsoft.EntityFrameworkCore;

namespace HeronsNest.Modules.Repository.BookBorrow
{
    public class BorrowRepository(BookContext context) : IBorrowRepository
    {
        private readonly BookContext Context = context;

        public async Task<Response<Book?>> BorrowBookAsync(Models.BookBorrow borrowDetails)
        {
            if (!(await CanBorrowAsync(borrowDetails.Id)).Data) return new(null, Enums.ActionResult.Failed, "Already borrowed by someone else.");
            var AddResult = await Context.AddAsync(borrowDetails);

            if (AddResult != null)
            {
                return new(AddResult.Entity.Book, Enums.ActionResult.Success);
            }

            return new(null, Enums.ActionResult.Failed);
        }

        public async Task<Response<bool>> CanBorrowAsync(string borrowId)
        {
            DateOnly res;
            
            try
            {
                var IsAlreadyBorrowed = (await Context.BookBorrows.ToListAsync()).First(
                x => x.Id == borrowId
                && x.DateBorrowed != null
                && DateOnly.TryParse(x.DateBorrowed, out res)
                && res.AddDays(3).CompareTo(DateOnly.FromDateTime(DateTime.Now)) < 0
                );

                return new(IsAlreadyBorrowed != null, Enums.ActionResult.Success);

            }   
            catch
            {
                return new(false, Enums.ActionResult.Success);
            }

        }

        public async Task<IEnumerable<Models.BookBorrow?>> GetBorrowedBooksAsync(Models.User? user)
        {
            return user == null
                ? await Context.BookBorrows.ToListAsync()
                : await Context.BookBorrows.Where(x => x.User!.Equals(user)).ToListAsync();
        }


        public async Task<Response<Models.BookBorrow?>> ReturnBookAsync(string borrowId, Models.User? user)
        {
            var BookToBeUpdated = await Context.BookBorrows.FirstAsync(
                x => x.Id == borrowId && x.User == user.Id
                && DateOnly.Parse(x.DateBorrowed!).AddDays(3).CompareTo(DateOnly.FromDateTime(DateTime.Now)) <= 0
                );

            BookToBeUpdated.DateReturned = DateOnly.FromDateTime(DateTime.Now).ToString();

            var UpdateResult = Context.BookBorrows.Update(BookToBeUpdated);

            if (UpdateResult.State == EntityState.Modified) return new(BookToBeUpdated, Enums.ActionResult.Success);

            return new(null, Enums.ActionResult.Failed);
        }

        public async Task<Response<Book?>> RevokeBorrowAsync(string borrowId, Models.User? user)
        {
            var ReferenceToBeDeleted = await Context.BookBorrows.FirstAsync(
                x => x.Id == borrowId && x.User == user.Id
                && DateOnly.Parse(x.DateBorrowed!).AddDays(3).CompareTo(DateOnly.FromDateTime(DateTime.Now)) <= 0
                );

            if (ReferenceToBeDeleted != null)
            {
                var DeleteUpdate = Context.BookBorrows.Remove(ReferenceToBeDeleted);
                SaveChanges();
                return new(null, Enums.ActionResult.Success);
            }

            return new(null, Enums.ActionResult.Failed, "Book Reference could not be found");
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
