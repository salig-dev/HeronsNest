using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms.Books
{
    internal class BooksSorter
    {
        public Book[] Sort(Book[] books)
        {
            int pivot = (int)Math.Floor((double)books.Length / 2);

            Book[] left = Sort(Partition(books, 0, pivot));
            Book[] right = Sort(Partition(books, pivot, books.Length - 1));

            return Merge(left, right);
        }

        private Book[] Partition(Book[] books, int start, int end)
        {
            List<Book> newBooks = [];

            for (int i = start; i < end; i++)
            {
                newBooks.Add(books[i]);
            }

            return [.. newBooks];
        }

        private Book[] Merge(Book[] left, Book[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            List<Book> sortedBooks = [];

            // Iterate through both arrays until one is exhausted
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (Convert.ToInt32(left[leftIndex].Isbn) <= Convert.ToInt32(right[rightIndex].Isbn))
                {
                    sortedBooks.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sortedBooks.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            // Append any remaining elements from the non-exhausted array
            sortedBooks.AddRange(left.Skip(leftIndex));
            sortedBooks.AddRange(right.Skip(rightIndex));

            return [.. sortedBooks];
        }
    }
}
