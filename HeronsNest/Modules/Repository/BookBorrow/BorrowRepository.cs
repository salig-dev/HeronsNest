using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var IsAlreadyBorrowed = await Context.BookBorrows.FirstAsync(
                x => x.Id == borrowId
                && DateOnly.Parse(x.DateBorrowed!).AddDays(3).CompareTo(DateOnly.FromDateTime(DateTime.Now)) <= 0
                );

            return new(IsAlreadyBorrowed != null, Enums.ActionResult.Success);
        }

        public async Task<IEnumerable<Models.BookBorrow?>> GetBorrowedBooksAsync(User? user)
        {
            return user == null
                ? await Context.BookBorrows.ToListAsync()
                : await Context.BookBorrows.Where(x => x.User!.Equals(user)).ToListAsync();
        }

        public async Task<Response<Models.BookBorrow?>> ReturnBookAsync(string borrowId, User user)
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

        public async Task<Response<Book?>> RevokeBorrowAsync(string borrowId, User user)
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
