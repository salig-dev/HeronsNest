﻿using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules.Response;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HeronsNest.Modules.Repository.BookBorrow
{
    public class BorrowRepository(BookContext context) : IBorrowRepository
    {
        private readonly BookContext Context = context;

        public async Task<Response<Book?>> BorrowBookAsync(Models.BookBorrow borrowDetails)
        {
            if ((await CanBorrowAsync(borrowDetails.BookId  )).Data) return new(null, Enums.ActionResult.Failed, "Already borrowed by someone else on this date");
            
            try
            {
                var AddResult = Context.BookBorrows.Add(borrowDetails);
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

            var IsAlreadyBorrowed = (await Context.BookBorrows.ToListAsync()).FirstOrDefault(
                x 
                => x != null
                && x.BookId == borrowId
                && (x.DateBorrowed != null || x.DateBorrowed != string.Empty)
                && DateTime.TryParse(x.DateBorrowed, out DateTime res)
                && res <= (DateTime.Now).AddDays(3)
                , null);

            return new(IsAlreadyBorrowed != null, Enums.ActionResult.Success);

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
                && DateTime.TryParse(x.DateBorrowed, out res)
                && res >= DateTime.Now.AddDays(3)
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

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}