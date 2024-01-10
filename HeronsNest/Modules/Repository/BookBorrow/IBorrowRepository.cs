using HeronsNest.Models;
using HeronsNest.Modules.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Repository.BookBorrow
{
    public interface IBorrowRepository
    {
        public Task<Response<Book?>> BorrowBookAsync(Models.BookBorrow borrowDetails);
        public Task<Response<Models.BookBorrow?>> ReturnBookAsync(string borrowId, User user);
        public Task<Response<Book?>> RevokeBorrowAsync(string borrowId, User user);
        public Task<IEnumerable<Models.BookBorrow?>> GetBorrowedBooksAsync(User? user, string bookIsbn = "");
        public Task<Response<bool>> CanBorrowAsync(string borrowId);

        public void SaveChanges();

    }
}
