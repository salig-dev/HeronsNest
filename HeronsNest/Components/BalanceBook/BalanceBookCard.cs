using HeronsNest.Components.Modal;
using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components
{
    public partial class BalanceBookCard : UserControl
    {
        private readonly BookBorrow BookBorrow;
        private Book Book;
        private readonly Landing MainForm;

        public BalanceBookCard(Landing mainForm, BookBorrow bookBorrow)
        {
            InitializeComponent();

            BookBorrow = bookBorrow;
            MainForm = mainForm;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Book = MainForm.BookTrie.Search(BookBorrow.BookId)[0];
            bookAuthor.Text = Book.Author;
            bookTitle.Text = Book.Title;

            DateTime dateBorrow = DateTime.ParseExact(BookBorrow.DateBorrowed!, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            DateTime dateDue = DateTime.ParseExact(BookBorrow.DateDue!, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            TimeSpan span = dateDue - dateBorrow;

            bookStatus.Text = "OVERDUE";
            penaltyVal.Text = "20";
            totalVal.Text = (20 * span.Days - 3).ToString();

            try
            {
                bookImage.LoadAsync(Book.CoverImg);
            }
            catch
            {
                Debug.WriteLine($"{Book.Isbn} does not have a proper image path!");
            }

        }

        private void OnPayButtonClick(object sender, EventArgs e)
        {
            MainForm.ShowPopup(new ReturnBook(MainForm, BookBorrow));
        }
    }
}
