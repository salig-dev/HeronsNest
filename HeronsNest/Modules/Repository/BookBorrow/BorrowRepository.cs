using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using User = HeronsNest.Models.User;

namespace HeronsNest.Modules.Repository.BookBorrow
{
    public class BorrowRepository(BookContext context) : IBorrowRepository
    {
        private readonly BookContext Context = context;

        public async Task<Response<Book?>> BorrowBookAsync(Models.BookBorrow borrowDetails)
        {
            var parsedReservedDate = DateTime.Now;
            var parsedBorrowedDate = DateTime.Now;
            if ((await CanBorrowAsync(borrowDetails.BookId)).Data) return new(null, Enums.ActionResult.Failed, "Already borrowed by someone else on this date");
            if (!(await CanUserBorrow(borrowDetails.UserNavigation!)).Data) return new(null, Enums.ActionResult.Failed, "User has max borrows already!");
            if (Context.BookReserves.Any(x =>
    x.UserId == borrowDetails.User &&
    x.Book == borrowDetails.BookId &&
    DateTime.TryParse(x.DateReserved, out parsedReservedDate) &&
    DateTime.TryParse(borrowDetails.DateBorrowed, out parsedBorrowedDate) &&
    parsedReservedDate == parsedBorrowedDate))
            {
                return new(null, Enums.ActionResult.Failed, "Already Reserved by Someone Else!");
            }

            try
            {            
                var AddResult = Context.BookBorrows.Add(borrowDetails);

                if (Context.BookReserves.Any(x => x.UserId == borrowDetails.User && x.Book == borrowDetails.BookId))
                {
                    var res = Context.BookReserves.Where(x => x.UserId == borrowDetails.User && x.Book == borrowDetails.BookId);
                    Context.BookReserves.RemoveRange(res);
                }

                SaveChanges();

                if (AddResult != null)
                {
                    return new(AddResult.Entity.Book, Enums.ActionResult.Success);
                }
            } catch (Exception e)
            {
                Debug.WriteLine(e.InnerException);
            }

            return new(null, Enums.ActionResult.Failed);
        }

        public async Task<Response<bool>> CanBorrowAsync(string borrowId)
        {
            var query = Context.BookBorrows.AsQueryable();

            query = query.Where(x => x.BookId.Equals(borrowId));

            DateTime parsedDate;
            var isBookReserved = query.ToList().Any(x =>
                DateTime.TryParseExact(x.DateBorrowed!, "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate) &&
                DateOnly.FromDateTime(parsedDate.Date) == DateOnly.FromDateTime(DateTime.Now)
            );  // Check for matches on both user and date

            return new(isBookReserved, Enums.ActionResult.Success);
        }

        public async Task<IEnumerable<Models.BookBorrow?>> GetBorrowedBooksAsync(Models.User? user, string bookIsbn = "")
        {
            var query = Context.BookBorrows.AsQueryable();

            if (user != null)
            {
                query = query.Where(x => x.User.Equals(user.Id));
            }

            if (bookIsbn != "")
            {
                query = query.Where(x => x.BookId == bookIsbn);
            }

            var borrows = await query.ToListAsync();
            return borrows;
        }


        public async Task<Response<Models.BookBorrow?>> ReturnBookAsync(string borrowId, Models.User? user)
        {
            DateTime res;

            var BookToBeUpdated = await Context.BookBorrows.FirstAsync(
                x => x.Id == borrowId && x.User == user.Id
                && x.DateBorrowed != null
                );

            BookToBeUpdated.DateReturned = DateOnly.FromDateTime(DateTime.Now).ToString();

            var UpdateResult = Context.BookBorrows.Update(BookToBeUpdated);
            SaveChanges();

            if (UpdateResult.State == EntityState.Modified) return new(BookToBeUpdated, Enums.ActionResult.Success);

            return new(null, Enums.ActionResult.Failed);
        }

        public async Task<Response<Book?>> RevokeBorrowAsync(string borrowId, Models.User? user)
        {
            DateTime res;

            var ReferenceToBeDeleted = await Context.BookBorrows.FirstAsync(
                x => x.Id == borrowId && x.User == user.Id
               && x.DateBorrowed != null
                && DateTime.TryParse(x.DateBorrowed, out res)
                && res >= DateTime.Now.AddDays(3)
                );

            if (ReferenceToBeDeleted != null)
            {
                var DeleteUpdate = Context.BookBorrows.Remove(ReferenceToBeDeleted);
                SaveChanges();
                return new(null, Enums.ActionResult.Success);
            }

            return new(null, Enums.ActionResult.Failed, "Book Reference could not be found");
        }

        public async Task<Response<bool>> CanUserBorrow(User user)
        {
            var AllUserBorrowedBooks = (await GetBorrowedBooksAsync(user)).ToList().Where(x => string.IsNullOrEmpty(x.DateReturned)).ToList();

            if (Convert.ToBoolean(user.IsTeacher)) return new(AllUserBorrowedBooks.Count < 5, Enums.ActionResult.Success);
            return new(AllUserBorrowedBooks.Count < 3, Enums.ActionResult.Success);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        
    }
}
