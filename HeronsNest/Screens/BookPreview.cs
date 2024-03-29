﻿using HeronsNest.Components.Modal;
using HeronsNest.Models;
using HeronsNest.Singleton;
using System.Diagnostics;
using System.Windows.Forms;

namespace HeronsNest.Screens
{
    public partial class BookPreview : UserControl
    {
        Landing mainForm;
        private readonly Book Book;
        public BookPreview(Landing mainForm, Book book)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            leftNavBar1.MainForm = mainForm;

            Book = book;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bookTitle.Text = Book.Title;
            bookAuthor.Text = Book.Author;
            bookYear.Text = Book.PublishDate;
            bookDetails.Text = Book.Description;
            bookRating.Text = "Rating: " + Book.Ratings.ToString() + " Stars";
            bookSeries.Text = "Series: " + Book.Series;
            ISBN.Text = "ISBN: " + Book.Isbn.ToString();
            bookGenre.Text = "Genre: " + Book.Genres;
            bookPublisher.Text = "Publisher: " + Book.Publisher;

            if (!Book.Genres.Contains("Academ"))
            {
                var IsBookBorrowed = mainForm.BorrowBook.CanBorrowBook(Book.Isbn).Result.Data;
                var IsBookReserved = mainForm.ReserveBook.CanReserveBook(Book.Isbn, DateTime.Now, "").Result.Data
                    || mainForm.ReserveBook.CanReserveBook(Book.Isbn, DateTime.Now, "").Result.Data;
                var CanUserBorrow = !mainForm.BorrowBook.CanUserBorrow(UserSession.Instance.User).Result.Data;

                bookStatus.Text = CanUserBorrow ? "MAX BORROWS" :
                           (IsBookReserved ? "RESERVED TODAY" :
                           (IsBookBorrowed ? "BORROWED TODAY" : "AVAILABLE"));

                bookStatus.BackColor = IsBookBorrowed || IsBookReserved || CanUserBorrow ? Color.Orange : Color.Green;

                borrowAndReserveDates.Visible = IsBookBorrowed || IsBookReserved;
            }
            else
            {
                

                bookStatus.Text = "CAN'T BORROW";

                bookStatus.BackColor = Color.Orange;
                borrowBtn.Visible = false;
                reserveBtn.Visible = false;

                borrowAndReserveDates.Visible = false;
            }

            

            bookLikepercentage.Text = "Liked: " + Book.LikedPercentage!.ToString() + "%";
            try
            {
                bookImg.LoadAsync(Book.CoverImg);
            }
            catch
            {
                Debug.WriteLine($"{Book.Isbn} does not have a proper image path!");
            }

            var relatedBooksOfAuthor = mainForm.AuthorBookTrie.SearchRelated(Book.Author!);
            foreach (var book in relatedBooksOfAuthor)
            {
                var pictureBox = new PictureBox();
                pictureBox.Size = otherBookCover.Size;
                try
                {
                    pictureBox.LoadAsync(book.CoverImg);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += (object sender, EventArgs e) =>
                    {
                        mainForm.SwitchView(new BookPreview(mainForm, book));
                    };
                }
                catch
                {
                    Debug.WriteLine($"{Book.Isbn} does not have a proper image path!");

                }

                otherBooksList.Controls.Add(pictureBox);
            }

            otherBooksList.Controls.RemoveAt(0);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void bookRating_Click(object sender, EventArgs e)
        {

        }

        private void statusText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void bookDetails_Click(object sender, EventArgs e)
        {

        }

        private void BookPreview_Load(object sender, EventArgs e)
        {

        }

        private void bookSeries_Click(object sender, EventArgs e)
        {

        }

        private void authorDetails_Enter(object sender, EventArgs e)
        {

        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            mainForm.ShowPopup(new ReserveBook(mainForm, Book.Isbn));
        }

        private void bookAuthor_Click(object sender, EventArgs e)
        {

        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void OnBorrowButtonClicked(object sender, EventArgs e)
        {
            mainForm.ShowPopup(new BorrowBook(mainForm, Book));
        }

        private void OnBookBorrowReserveDateCheck(object sender, EventArgs e)
        {
            mainForm.ShowPopup(new ReserveBorrowDateCheckModal(mainForm, Book.Isbn));
        }
    }
}
