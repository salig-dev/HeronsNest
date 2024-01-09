using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules.Repository.BookBorrow;
using HeronsNest.Modules.Response;
using Microsoft.EntityFrameworkCore;

namespace HeronsNest.Modules.Repository.BookReserve
{
    public class ReserveRepository(BookContext context) : IReserveRepository
    {
        private readonly BookContext Context = context;

        public async Task<Response<bool>> CanReserveAsync(Book book, DateOnly Date)
        {
            var Book = await Context.BookReserves.FindAsync(book);

            return new(Book != null && DateOnly.FromDateTime(DateTime.Now) != DateOnly.Parse(Book.DateReserved!), Enums.ActionResult.Success);
        }

        public async Task<IEnumerable<Models.BookReserve>> GetReservedBooksAsync(User? user)
        {
            return user != null 
                ? Context.BookReserves.Where(x => x.UserId == user.Id) 
                : await Context.BookReserves.ToListAsync();
        }

        public async Task<Response<Book?>> ReserveBookAsync(Models.BookReserve book)
        {
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
