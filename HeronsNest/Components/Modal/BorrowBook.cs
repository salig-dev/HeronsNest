using HeronsNest.Models;
using HeronsNest.Modules.Enums;
using HeronsNest.Screens;
using HeronsNest.Singleton;
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

            DateBorrow.MinDate = DateTime.Now;
            DateReturn.Value = DateBorrow.Value.AddDays(3);
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
            for (int i = 0; i < 23; i++)
            {
                generatedId += x[r.Next(0, x.Length - 1)];
            }

            var Response = MainForm.BorrowBook.Borrow(new()
            {
                BookId = Book.Isbn,
                DateBorrowed = DateBorrow.Value.ToString(),
                DateDue = DateBorrow.Value.AddDays(3).ToString(),
                DateReturned = "",
                User = UserSession.Instance.User.Id,
                Id = generatedId
            }).Result;

            if (Response.Result == ActionResult.Failed)
            {
                actionMessageLbl.Text = Response.Message;
                return;
            }
            actionMessageLbl.Text = "";

            MainForm.RemovePopup();
            MainForm.SwitchView(new MyShelf(MainForm));
        }

        private void OnDateValueChanged(object sender, EventArgs e)
        {
            DateReturn.Value = DateBorrow.Value.AddDays(3);
        }
    }
}
