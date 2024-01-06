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
    public partial class BalanceBookCard : UserControl
    {
        private readonly BookReservation BookReservation;
        private readonly Book Book;

        public BalanceBookCard(BookReservation bookReservation, Book book)
        {
            InitializeComponent();

            BookReservation = bookReservation;
            Book = book;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bookAuthor.Text = Book.Author;
            bookTitle.Text = Book.Title;

            // bookStatus.Text = 
            // penaltyVal.Text =
            // totalValText = 

            // Load Image - di ko pa na test kung gumagana
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
