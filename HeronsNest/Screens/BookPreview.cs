using HeronsNest.Components.Modal;
using HeronsNest.Models;
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
            bookRating.Text = Book.Ratings.ToString() + " Stars";
            bookSeries.Text = Book.Series;
            ISBN.Text = Book.Isbn.ToString();
            bookGenre.Text = Book.Genres;
            bookPublisher.Text = Book.Publisher;

            bookLikepercentage.Text = Book.LikedPercentage.ToString() + "%";
            try
            {
                bookImg.LoadAsync(Book.CoverImg);
            }
            catch
            {
                Debug.WriteLine($"{Book.Isbn} does not have a proper image path!");
            }

            var relatedBooksOfAuthor = mainForm.AuthorBookTrie.FindRelatedBooks(Book.Author!);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void ReturnToLibraryBtn_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            mainForm.ShowPopup(new BorrowBook(mainForm));
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            mainForm.ShowPopup(new ReserveBook(mainForm));
        }
    }
}
