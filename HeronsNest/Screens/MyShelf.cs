using HeronsNest.Components;
using HeronsNest.Components.Modal;
using HeronsNest.Models;
using HeronsNest.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Screens
{
    public partial class MyShelf : UserControl
    {

        Landing mainForm;

        List<BookBorrow> bookBorrows;
        List<BookReserve> bookReserves;

        public MyShelf(Landing mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            leftNavBar1.MainForm = mainForm;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bookBorrows = await mainForm.BorrowBook.GetAllBorrows(UserSession.Instance.User);
            bookReserves = await mainForm.ReserveBook.GetAllReservations(UserSession.Instance.User);

            foreach (BookBorrow r in bookBorrows)
            {
                BookCard card = new(r, mainForm.BookTrie.Search(r.BookId!.ToLowerInvariant())[0]);
                cardListView.Controls.Add(card);

                card.OnMainButtonClicked += (object e, EventArgs a) =>
                {
                    mainForm.ShowPopup(new ReturnBook(mainForm, r));
                };
            }

            foreach (BookReserve r in bookReserves)
            {
                Book book = mainForm.BookTrie.Search(r.Book.ToLowerInvariant()!)[0];
                var canReserve = mainForm.ReserveBook.CanReserveBook(book.Isbn, DateTime.Now, UserSession.Instance.User.Id).Result.Data;
                BookCard card = new(r, book, canReserve);


                if (canReserve)
                {
                    card.OnMainButtonClicked += (object e, EventArgs a) =>
                    {
                        mainForm.ShowPopup(new BorrowBook(mainForm, book));
                    };
                }

                cardListView.Controls.Add(card);
            }
        }

        private void MyShelf_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void OnAllBooksNavigate(object sender, EventArgs e)
        {
            cardListView.Controls.Clear();
            var completedBooks = bookBorrows.Where(x => string.IsNullOrEmpty(x.DateReturned));

            foreach (BookBorrow r in completedBooks)
            {
                BookCard card = new(r, mainForm.BookTrie.Search(r.BookId!.ToLowerInvariant())[0]);
                cardListView.Controls.Add(card);

                card.OnMainButtonClicked += (object e, EventArgs a) =>
                {
                    mainForm.ShowPopup(new ReturnBook(mainForm, r));
                };
            }

            foreach (BookReserve r in bookReserves)
            {
                Book book = mainForm.BookTrie.Search(r.Book!.ToLowerInvariant())[0];
                var canReserve = mainForm.ReserveBook.CanReserveBook(book.Isbn, DateTime.Now, UserSession.Instance.User.Id).Result.Data;
                BookCard card = new(r, book, canReserve);


                if (canReserve)
                {
                    card.OnMainButtonClicked += (object e, EventArgs a) =>
                    {
                        mainForm.ShowPopup(new BorrowBook(mainForm, book));
                    };
                }

                cardListView.Controls.Add(card);
            }
        }

        private void OnReservedBooksNavigate(object sender, EventArgs e)
        {
            cardListView.Controls.Clear();

            foreach (BookReserve r in bookReserves)
            {
                Book book = mainForm.BookTrie.Search(r.Book!.ToLowerInvariant())[0];
                var canReserve = mainForm.ReserveBook.CanReserveBook(book.Isbn, DateTime.Now, UserSession.Instance.User.Id).Result.Data;
                BookCard card = new(r, book, canReserve);


                if (canReserve)
                {
                    card.OnMainButtonClicked += (object e, EventArgs a) =>
                    {
                        mainForm.ShowPopup(new BorrowBook(mainForm, book));
                    };
                }

                cardListView.Controls.Add(card);
            }
        }

        private void OnPendingBooksNavigate(object sender, EventArgs e)
        {
            cardListView.Controls.Clear();

            foreach (BookBorrow r in bookBorrows)
            {
                BookCard card = new(r, mainForm.BookTrie.Search(r.BookId!.ToLowerInvariant())[0]);
                cardListView.Controls.Add(card);
            }

        }

        private void OnCompletedBooksNavigate(object sender, EventArgs e)
        {
            cardListView.Controls.Clear();
            var completedBooks = bookBorrows.Where(x => !string.IsNullOrEmpty(x.DateReturned));
            foreach (BookBorrow r in completedBooks)
            {
                BookCard card = new(r, mainForm.BookTrie.Search(r.BookId!.ToLowerInvariant())[0]);
                cardListView.Controls.Add(card);

                
            }
        }
    }
}
