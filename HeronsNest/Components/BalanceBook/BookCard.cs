using HeronsNest.Models;
using HeronsNest.Modules.Books;
using System.Data;
using System.Diagnostics;


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
            remove => onMainButtonClicked -= null;
        }

        public BookCard(BookBorrow bookBorrow, Book book)
        {
            InitializeComponent();

            BookBorrow = bookBorrow;
            Book = book;
        }

        public BookCard(BookReserve bookReserve, Book book, bool canBorrow)
        {
            InitializeComponent();

            BookReserve = bookReserve;
            Book = book;
            CanBorrow = canBorrow;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (BookBorrow != null)
            {
                borrowedDate.Text = DateTime.Parse(BookBorrow.DateBorrowed!).ToShortDateString();
                returnDate.Text = DateTime.Parse(BookBorrow.DateDue!).ToShortDateString();

                borrowedBtn.Text = "Borrowed";
                borrowedBtn.BackColor = Color.FromArgb(0, 149, 168);
            }

            if (BookReserve != null)
            {
                borrowedDate.Text = DateTime.Parse(BookReserve.DateReserved!).ToShortDateString();
                returnDate.Text = "--";

                borrowedBtn.Text = "Reserved";
                borrowedBtn.BackColor = Color.FromArgb(255, 128, 0);

                returnBtn.Text = CanBorrow ? "Borrow" : "Cannot be Borrowed";
                returnBtn.BackColor = CanBorrow ? Color.FromArgb(0, 149, 168) : Color.OrangeRed;
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

        private void OnActionButtonClick(object sender, EventArgs e)
        {
            onMainButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
