using HeronsNest.Models;

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
            authorName.Text = Book.Author;
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
    }
}
