using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules.Repository.BookBorrow;
using HeronsNest.Modules.Response;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HeronsNest.Modules.Repository.BookReserve
{
    public class ReserveRepository(BookContext context) : IReserveRepository
    {
        private readonly BookContext Context = context;

        public async Task<Response<bool>> CanReserveAsync(string bookIsbn, DateOnly Date, string userId = "")
        {
            var query = Context.BookReserves.AsQueryable();

            if (!string.IsNullOrEmpty(userId))
            {
                query = query.Where(x => x.UserId == userId);
            }

            query = query.Where(x => x.Book.Equals(bookIsbn));

            var parsedDate = DateTime.Now;
            var isBookReserved = query.ToList().Any(x =>
                DateTime.TryParse(x.DateReserved!, out parsedDate) && 
                DateOnly.FromDateTime(parsedDate) == Date 
            );

            return new(isBookReserved, Enums.ActionResult.Success);
        }

        public async Task<IEnumerable<Models.BookReserve>> GetReservedBooksAsync(User? user, string bookIsbn = "")
        {
            var query = Context.BookReserves.AsQueryable();

            if (user != null)
            {
                query = query.Where(x => x.User.Id.Equals(user.Id));
            }

            if (bookIsbn != "")
            {
                query = query.Where(x => x.Book == bookIsbn);
            }

            var reserves = await query.ToListAsync();
            return reserves;
        }

        public async Task<Response<Book?>> ReserveBookAsync(Models.BookReserve book)
        {
            if ((await CanReserveAsync(book.Book, DateOnly.FromDateTime(DateTime.Parse(book.DateReserved)), null)).Data) return new ReserveResponse<Book?>(null, Enums.ActionResult.Failed, "Book is already reserved on this day!");
            var Response = await Context.BookReserves.AddAsync(book);
            SaveChanges();

            if (Response != null)
            {
                return new ReserveResponse<Book?>(null, Enums.ActionResult.Success);
            }

            return new ReserveResponse<Book?>(null, Enums.ActionResult.Failed);
        }

        public async Task<Response<Book?>> RevokeReservationAsync(string reserveId)
        {
            var BookReservationReference = await Context.BookReserves.FirstAsync(x => x.ReservationId == reserveId);

            if (BookReservationReference != null)
            {
                Context.BookReserves.Remove(BookReservationReference);
                SaveChanges();
                return new Response<Book?>(null, Enums.ActionResult.Success);
            }

            return new Response<Book?>(null, Enums.ActionResult.Failed);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
