using HeronsNest.Models;
using HeronsNest.Modules.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Repository.BookReserve
{
    public interface IReserveRepository
    {
        public Task<Response<Book?>> ReserveBookAsync(Models.BookReserve book);
        public Task<Response<Book?>> RevokeReservationAsync(string reserveId);
        public Task<IEnumerable<Models.BookReserve>> GetReservedBooksAsync(User? user, string bookIsbn = "");
        public Task<Response<bool>> CanReserveAsync(Book book, DateOnly Date);

        public void SaveChanges();
    }
}
