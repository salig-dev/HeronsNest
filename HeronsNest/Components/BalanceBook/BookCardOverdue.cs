using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components
{
    public partial class BookCardOverdue : UserControl
    {

        private readonly BookReservation BookReservation;
        private readonly Book Book;

        public BookCardOverdue(BookReservation bookReservation, Book book)
        {
            InitializeComponent();

            BookReservation = bookReservation;
            Book = book;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            borrowedDate.Text = DateTime.Parse(BookReservation.DateReserved).ToShortDateString();
            returnDate.Text = DateTime.Parse(BookReservation.DateReturn).ToShortDateString();

            bookAuthor.Text = Book.Author;
            bookTitle.Text = Book.Title;

            // TODO: LOAD IMAGE
            try
            {
                bookImage.LoadAsync(Book.CoverImg);
            }
            catch
            {
                Debug.WriteLine($"{Book.Isbn} does not have a proper image path!");
            }

        }
    }
}
