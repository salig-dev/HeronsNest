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

        public BookCard(BookBorrow bookBorrow, Book book)
        {
            InitializeComponent();

            BookBorrow = bookBorrow;
            Book = book;
        }

        public BookCard(BookReserve bookReserve, Book book)
        {
            InitializeComponent();

            BookReserve = bookReserve;
            Book = book;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (BookBorrow != null)
            {
                borrowedDate.Text = DateTime.Parse(BookBorrow.DateBorrowed!).ToShortDateString();
                returnDate.Text = DateTime.Parse(BookBorrow.DateDue!).ToShortDateString();
            }

            if (BookReserve != null)
            {
                borrowedDate.Text = DateTime.Parse(BookReserve.DateReserved!).ToShortDateString();
                returnDate.Text = "--";
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

    }
}
