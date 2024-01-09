using HeronsNest.Models;
using HeronsNest.Modules.Repository.BookBorrow;
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
        
        public void Borrow(Models.BookBorrow borrowDetails)
        {
            _borrowRepository.BorrowBookAsync(borrowDetails);
        }

        public void Return(string borrowId)
        {
            _borrowRepository.ReturnBookAsync(borrowId, UserSession.Instance.User);
        }

        public void Revoke(string borrowId)
        {
            _borrowRepository.RevokeBorrowAsync(borrowId, UserSession.Instance.User);
        }

        public async Task<List<BookBorrow>> GetAllBorrows(User? user)
        {
            return (await _borrowRepository.GetBorrowedBooksAsync(user)).ToList();
        }
    }
}
