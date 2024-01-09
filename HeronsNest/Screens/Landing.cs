using HeronsNest.Algorithms;
using HeronsNest.Algorithms.Authentication;
using HeronsNest.Algorithms.Loaders;
using HeronsNest.Components.Modal;
using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Modules;
using HeronsNest.Modules.Repository;
using HeronsNest.Modules.Repository.BookBorrow;
using HeronsNest.Modules.Repository.BookReserve;
using HeronsNest.Modules.Repository.Trie;
using HeronsNest.Screens;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;

namespace HeronsNest
{
    public partial class Landing : Form
    {
        List<Control> screens = [];
        BookContext? bookDbContext;

        BookLoader? bookLoader;
        CategoryLoader? categoryLoader;
        Authenticator authenticator;

        readonly Trie<Book> bookTrie = new();
        readonly Trie<Book> authorBookTrie = new();
        readonly Trie<Book> titleBookTrie = new();
        readonly Trie<Book> categoryBookTrie = new();

        readonly Sorter<Book> sorter = new();

        private IBorrowRepository borrowRepository;
        private IReserveRepository reserveRepository;

        private Modules.Books.BorrowBook borrowBook;
        private Modules.Books.ReserveBook reserveBook;

        public BookLoader? BookLoader { get { return bookLoader; } }
        public CategoryLoader? CategoryLoader { get { return categoryLoader; } }
        public Authenticator? Authenticator { get { return authenticator; } }

        public Trie<Book> BookTrie {  get { return bookTrie; } }  
        public Trie<Book> AuthorBookTrie {  get { return authorBookTrie; } }
        public Trie<Book> TitleBookTrie {  get { return titleBookTrie; } }
        public Trie<Book> CategoryBookTrie { get { return categoryBookTrie; } }

        public Sorter<Book> Sorter { get { return sorter; } }

        public Modules.Books.BorrowBook BorrowBook { get { return borrowBook;  } }
        public Modules.Books.ReserveBook ReserveBook { get { return reserveBook; } }
        private void InitializeScreens()
        {
            // By default, the VERY FIRST screen inserted here shall be the
            // default page.
            screens.Add(new Login(this));
            screens.Add(new Home(this));
        }

        public Landing()
        {
            InitializeComponent();
            InitializeScreens();

            if (screens.Count > 0)
            {
                // The very first item inserted in the list will
                // be the default screen.
                if (Controls.Count <= 0)
                {
                    SwitchView(screens[0]);
                }
            }
            else
            {
                throw new Exception(
                    "There are no screens initialized. " +
                    "Make sure that the screens array has screens initialized.");
            }
        }

        public void SwitchView(Control c)
        {
            // Since iisa lang rin naman naka-lagay na
            // screen edi clear nalang natin lahat
            Controls.Clear();

            // meaning neto, c will fill the whole 
            // form
            c.Dock = DockStyle.Fill;

            // then saka natin sha i-add don sa mismong form
            Controls.Add(c);
        }

        public void ShowPopup(Control modal)
        {
            // Hide the screen (just for safety purposes)
            Controls[0].Hide();

            // Create an instance of the background and just
            // replace the placeholder modal with  whatever is passed in the ShowPopup
            ModalControl _modal = new();
            _modal.Dock = DockStyle.Fill;
            _modal.InsertNewModal(modal);

            // then add it
            Controls.Add(_modal);
        }

        public void RemovePopup()
        {
            Controls.RemoveAt(Controls.Count - 1);
            Controls[0].Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bookDbContext = new();

            bookDbContext.Books.Load();
            bookDbContext.Categories.Load();

            bookLoader = new(bookDbContext);
            categoryLoader = new(bookDbContext);
            authenticator = new(bookDbContext);

            borrowRepository = new BorrowRepository(bookDbContext);
            reserveRepository = new ReserveRepository(bookDbContext);

            borrowBook = new(borrowRepository);
            reserveBook = new(reserveRepository);

            // load trie tree in another thread
            Task.Run(() =>
            {
                var allBooks = BookLoader.GetAllBooks();

                foreach (var book in allBooks)
                {
                    bookTrie.Insert(book, book.Isbn);
                    authorBookTrie.Insert(book, book.Author ?? "");
                    titleBookTrie.Insert(book, book.Title ?? "");

                    // different loading way for category
                    var diffGenres = book.Genres.Split(",");
                    foreach(var genre in diffGenres)
                    {
                        categoryBookTrie.Insert(book, genre);
                    }
                }

                Debug.WriteLine("All books are loaded into Trie");
            });
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            bookDbContext?.Dispose();
            bookDbContext = null;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }
    }
}