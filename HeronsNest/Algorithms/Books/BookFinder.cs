using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms.Books
{
    internal class BookFinder
    {
        public List<Book> FindFromCategory(List<Book> source, Category category, int limit = 0)
        {
            var foundBooks = source.FindAll(match => match.Genres!.Contains(category.CategoryName!));

            if (foundBooks.Count >= limit) return foundBooks;
            if (limit > 0) return foundBooks[..limit];

            return foundBooks;
        }

        public Book? FindFromISBN(List<Book> source, string ISBN)
        {
            return source.Find(match => match.Isbn == ISBN);
        }
    }
}
