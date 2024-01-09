using HeronsNest.Models;
using HeronsNest.Modules.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Modules.Repository
{
    public interface IBookRepository<T>
    {
        public Response<T> AddBook(Book books);
        public Response<T> FindBook(Book books);
        public Response<T> UpdateBook(Book books);
        public Response<T> DeleteBook(Book books);

        public void SaveChanges();
    }
}
