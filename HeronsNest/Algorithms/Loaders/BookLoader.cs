using HeronsNest.Algorithms.Books;
using HeronsNest.Context;
using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms.Loaders
{
    public class BookLoader(BookContext context)
    {
        private readonly BookContext bookContext = context;
        private readonly BookFinder bookFinder = new();

        public List<Book> GetBooksFromCategory(Category category)
        {
            var data = bookContext.Books.ToList();
            return bookFinder.FindFromCategory(data, category);
        }

        public List<Book> GetBooksFromCategory(Category category, int limit)
        {
            var data = bookContext.Books.ToList();
            return bookFinder.FindFromCategory(data, category, limit);
        }

        public Book? GetBookWithISBN(string ISBN)
        {
            var data = bookContext.Books.ToList();
            return bookFinder.FindFromISBN(data, ISBN);
        }

        public List<Book> GetAllBooks() => bookContext.Books.ToList();
    }
}
