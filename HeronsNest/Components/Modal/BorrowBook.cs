using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components.Modal
{
    public partial class BorrowBook : UserControl
    {
        Landing MainForm;
        Book Book;
        public BorrowBook(Landing mainForm, Book book)
        {
            InitializeComponent();

            MainForm = mainForm;
            Book = book;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }

        private void OnReserve(object sender, EventArgs e)
        {
            char[] x = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890#$^&*()".ToCharArray();
            string generatedId = "";
            Random r = new();
            for (int i = 0; i < 24; i++)
            {
                generatedId += x[r.Next(0, x.Count() - 1)];
            }

            MainForm.BorrowBook.Borrow(new()
            {
                BookId = Book.BookId,
                DateBorrowed = DateBorrow.Value.ToString(),
                DateDue = DateBorrow.Value.AddDays(3).ToString(),
                DateReturned = "",
                Id = generatedId
            });

            MainForm.RemovePopup();
        }
    }
}
