using HeronsNest.Models;
using HeronsNest.Modules.Repository.BookReserve;
using HeronsNest.Modules.Response;

namespace HeronsNest.Modules.Books
{
    public class ReserveBook(IReserveRepository reserveRepository)
    {
        private readonly IReserveRepository _reserveRepository = reserveRepository;

        public void Reserve(Models.BookReserve bookReserveDetails)
        {
            _reserveRepository.ReserveBookAsync(bookReserveDetails);
        }

        public void Revoke(string reserveId)
        {
            _reserveRepository.RevokeReservationAsync(reserveId);
        }

        public async Task<List<BookReserve>> GetAllReservations(User? user, string bookIsbn = "")
        {
            return (await _reserveRepository.GetReservedBooksAsync(user, bookIsbn)).ToList();
        }

        public Task<Response<bool>> CanReserveBook(Book book, DateTime date)
        {
            return _reserveRepository.CanReserveAsync(book, DateOnly.FromDateTime(date));
        } 

    }
}
