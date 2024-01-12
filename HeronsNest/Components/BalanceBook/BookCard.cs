using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using HeronsNest.Models;
using HeronsNest.Screens;
using System.Globalization;

namespace HeronsNest.Components
{
    public partial class BookCard : UserControl
    {
        private readonly BookBorrow? BookBorrow;
        private readonly BookReserve? BookReserve;
        private readonly Book Book;
        private readonly bool CanBorrow;
        private readonly Landing MainForm;

        private EventHandler onMainButtonClicked;

        public event EventHandler OnMainButtonClicked
        {
            add => onMainButtonClicked += value;
            remove => onMainButtonClicked -= value;
        }

        public BookCard(Landing mainForm, BookBorrow bookBorrow, Book book)
        {
            InitializeComponent();

            BookBorrow = bookBorrow;
            Book = book;
            MainForm = mainForm;

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

                DateTime dateBorrow = DateTime.ParseExact(BookBorrow.DateBorrowed!, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                DateTime dateDue = DateTime.ParseExact(BookBorrow.DateDue!, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                TimeSpan span = dateDue - dateBorrow;


                borrowedBtn.Text = "Borrowed";
                borrowedBtn.BackColor = Color.FromArgb(0, 149, 168);

                
                if (span.Days < 3 && string.IsNullOrEmpty(BookBorrow.DateReturned))
                {
                    borrowedBtn.Visible = false;
                    pictureBox1.Image = Properties.Resources.card_overdue;
                }
            }

            if (BookReserve != null)
            {
                SetDateText(borrowedDate, BookReserve.DateReserved);
                returnDate.Text = "--";

                borrowedBtn.Text = "Reserved";
                borrowedBtn.BackColor = Color.FromArgb(255, 128, 0);

                returnBtn.Text = CanBorrow ? "Borrow" : "Can't Borrow";
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

        private void OnCardClicked(object sender, EventArgs e)
        {
            MainForm.SwitchView(new BookPreview(MainForm, Book));
        }
    }
}
