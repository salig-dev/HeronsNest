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

            DateTime dateBorrow = DateTime.Parse(BookBorrow.DateBorrowed);
            DateTime dateDue = DateTime.Parse(BookBorrow.DateDue);

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
    }
}
