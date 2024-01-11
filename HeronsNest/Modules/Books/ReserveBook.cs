using HeronsNest.Models;
using HeronsNest.Modules.Repository.BookReserve;
using HeronsNest.Modules.Response;
using Microsoft.VisualBasic.ApplicationServices;

namespace HeronsNest.Modules.Books
{
    public class ReserveBook(IReserveRepository reserveRepository)
    {
        private readonly IReserveRepository _reserveRepository = reserveRepository;

        public Task<Response<Book?>> Reserve(Models.BookReserve bookReserveDetails)
        {
            return _reserveRepository.ReserveBookAsync(bookReserveDetails);
        }

        public void Revoke(string reserveId)
        {
            _reserveRepository.RevokeReservationAsync(reserveId);
        }

        public async Task<List<BookReserve>> GetAllReservations(Models.User? user, string bookIsbn = "")
        {
            return (await _reserveRepository.GetReservedBooksAsync(user, bookIsbn)).ToList();
        }

        public Task<Response<bool>> CanReserveBook(string bookIsbn, DateTime date, string userId)
        {
            return _reserveRepository.CanReserveAsync(bookIsbn, DateOnly.FromDateTime(date), userId);
        } 

    }
}
