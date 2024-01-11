using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using HeronsNest.Models;

namespace HeronsNest.Components
{
    public partial class BookCard : UserControl
    {
        private readonly BookBorrow? BookBorrow;
        private readonly BookReserve? BookReserve;
        private readonly Book Book;
        private readonly bool CanBorrow;

        private EventHandler onMainButtonClicked;

        public event EventHandler OnMainButtonClicked
        {
            add => onMainButtonClicked += value;
            remove => onMainButtonClicked -= value;
        }

        public BookCard(BookBorrow bookBorrow, Book book)
        {
            InitializeComponent();

            BookBorrow = bookBorrow;
            Book = book;

            InitializeCard();
        }

        public BookCard(BookReserve bookReserve, Book book, bool canBorrow)
        {
            InitializeComponent();

            BookReserve = bookReserve;
            Book = book;
            CanBorrow = canBorrow;

            InitializeCard();
        }

        private void InitializeCard()
        {
            if (BookBorrow != null)
            {
                SetDateText(borrowedDate, BookBorrow.DateBorrowed);
                SetDateText(returnDate, BookBorrow.DateDue);

                borrowedBtn.Text = "Borrowed";
                borrowedBtn.BackColor = Color.FromArgb(0, 149, 168);
            }

            if (BookReserve != null)
            {
                SetDateText(borrowedDate, BookReserve.DateReserved);
                returnDate.Text = "--";

                borrowedBtn.Text = "Reserved";
                borrowedBtn.BackColor = Color.FromArgb(255, 128, 0);

                returnBtn.Text = CanBorrow ? "Borrow" : "Cannot be Borrowed";
                returnBtn.BackColor = CanBorrow ? Color.FromArgb(0, 149, 168) : Color.OrangeRed;
                returnBtn.Click += OnActionButtonClick;
            }

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

        private void SetDateText(Label label, string date)
        {
            if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out var parsedDate))
            {
                label.Text = parsedDate.ToShortDateString();
            }
        }

        private void OnActionButtonClick(object sender, EventArgs e)
        {
            onMainButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
