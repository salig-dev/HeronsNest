using HeronsNest.Models;
using HeronsNest.Modules.Repository.BookBorrow;
using HeronsNest.Modules.Response;
using HeronsNest.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Books
{
    public class BorrowBook(IBorrowRepository borrowRepository)
    {
        private readonly IBorrowRepository _borrowRepository = borrowRepository;

        public Task<Response<Book?>> Borrow(Models.BookBorrow borrowDetails)
        {
            return _borrowRepository.BorrowBookAsync(borrowDetails);
        }

        public Task<Response<BookBorrow?>> Return(string borrowId, User? user)
        {
            return _borrowRepository.ReturnBookAsync(borrowId, user);
        }

        public Task<Response<Book?>> Revoke(string borrowId)
        {
            return _borrowRepository.RevokeBorrowAsync(borrowId, UserSession.Instance.User);
        }

        public async Task<List<BookBorrow>> GetAllBorrows(User? user, string bookIsbn = "")
        {
            return (await _borrowRepository.GetBorrowedBooksAsync(user, bookIsbn)).ToList();
        }

        public Task<Response<bool>> CanBorrowBook(string borrowId)
        {
            return _borrowRepository.CanBorrowAsync(borrowId);   
        }

        public Task<Response<bool>> CanUserBorrow(User user)
        {
            return _borrowRepository.CanUserBorrow(user);
        }
    }
}
