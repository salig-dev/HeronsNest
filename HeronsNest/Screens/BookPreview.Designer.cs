namespace HeronsNest.Screens
{
    partial class BookPreview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookPreview));
            bookImage = new PictureBox();
            bookTitle = new Label();
            bookAuthor = new Label();
            bookYear = new Label();
            bookRating = new Label();
            statusText = new Label();
            bookStatus = new Label();
            borrowBtn = new Button();
            reserveBtn = new Button();
            bookAbout = new Label();
            bookDetails = new Label();
            authorDetails = new GroupBox();
            otherBooksList = new Components.List.CustomListView();
            otherBookCover = new PictureBox();
            bookLikepercentage = new Label();
            bookPublisher = new Label();
            bookGenre = new Label();
            bookSeries = new Label();
            label1 = new Label();
            aboutBook = new Label();
            leftNavBar1 = new Components.LeftNavBar();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            comp_DateTime1 = new Components.Comp_DateTime();
            imageList1 = new ImageList(components);
            bookImg = new PictureBox();
            ISBN = new Label();
            customListView1 = new Components.List.CustomListView();
            backBtn = new Label();
            backIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            authorDetails.SuspendLayout();
            otherBooksList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)otherBookCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookImg).BeginInit();
            customListView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backIcon).BeginInit();
            SuspendLayout();
            // 
            // bookImage
            // 
            bookImage.Image = Properties.Resources.previewCard;
            bookImage.Location = new Point(229, 119);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(208, 283);
            bookImage.SizeMode = PictureBoxSizeMode.AutoSize;
            bookImage.TabIndex = 2;
            bookImage.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.Font = new Font("PP Hatton", 12F);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.ImageAlign = ContentAlignment.MiddleLeft;
            bookTitle.Location = new Point(443, 119);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(250, 50);
            bookTitle.TabIndex = 3;
            bookTitle.Text = "Book Title Here....";
            bookTitle.TextAlign = ContentAlignment.MiddleLeft;
            bookTitle.Click += label2_Click;
            // 
            // bookAuthor
            // 
            bookAuthor.AutoEllipsis = true;
            bookAuthor.Font = new Font("Nourd-Regular", 10F);
            bookAuthor.Location = new Point(443, 180);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(260, 20);
            bookAuthor.TabIndex = 4;
            bookAuthor.Text = "By Author Name";
            bookAuthor.Click += bookAuthor_Click;
            // 
            // bookYear
            // 
            bookYear.AutoEllipsis = true;
            bookYear.Font = new Font("Nourd-Regular", 8F);
            bookYear.Location = new Point(445, 211);
            bookYear.Name = "bookYear";
            bookYear.Size = new Size(260, 20);
            bookYear.TabIndex = 5;
            bookYear.Text = "Year";
            bookYear.Click += label2_Click_1;
            // 
            // bookRating
            // 
            bookRating.AutoSize = true;
            bookRating.Font = new Font("PP Hatton", 10F);
            bookRating.ForeColor = Color.FromArgb(76, 76, 76);
            bookRating.Location = new Point(443, 261);
            bookRating.Name = "bookRating";
            bookRating.Size = new Size(106, 17);
            bookRating.TabIndex = 6;
            bookRating.Text = "Rating Here";
            bookRating.Click += bookRating_Click;
            // 
            // statusText
            // 
            statusText.Font = new Font("Nourd-Regular", 8F);
            statusText.Location = new Point(443, 289);
            statusText.Name = "statusText";
            statusText.Size = new Size(44, 20);
            statusText.TabIndex = 8;
            statusText.Text = "Status: ";
            statusText.TextAlign = ContentAlignment.MiddleCenter;
            statusText.Click += statusText_Click;
            // 
            // bookStatus
            // 
            bookStatus.BackColor = Color.FromArgb(82, 167, 133);
            bookStatus.FlatStyle = FlatStyle.Flat;
            bookStatus.Font = new Font("Nourd-Regular", 8F, FontStyle.Bold);
            bookStatus.ForeColor = Color.White;
            bookStatus.Location = new Point(443, 309);
            bookStatus.Name = "bookStatus";
            bookStatus.Size = new Size(100, 20);
            bookStatus.TabIndex = 9;
            bookStatus.Text = "AVAILABLE";
            bookStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // borrowBtn
            // 
            borrowBtn.BackColor = Color.FromArgb(0, 149, 168);
            borrowBtn.FlatAppearance.BorderSize = 0;
            borrowBtn.FlatStyle = FlatStyle.Flat;
            borrowBtn.Font = new Font("PP Hatton", 9F);
            borrowBtn.ForeColor = Color.White;
            borrowBtn.Location = new Point(443, 343);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(110, 30);
            borrowBtn.TabIndex = 10;
            borrowBtn.Text = "BORROW";
            borrowBtn.UseVisualStyleBackColor = false;
            borrowBtn.Click += borrowBtn_Click;
            // 
            // reserveBtn
            // 
            reserveBtn.BackColor = Color.FromArgb(82, 167, 133);
            reserveBtn.FlatAppearance.BorderSize = 0;
            reserveBtn.FlatStyle = FlatStyle.Flat;
            reserveBtn.Font = new Font("PP Hatton", 9F);
            reserveBtn.ForeColor = Color.White;
            reserveBtn.Location = new Point(559, 343);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(110, 30);
            reserveBtn.TabIndex = 10;
            reserveBtn.Text = "RESERVE";
            reserveBtn.UseVisualStyleBackColor = false;
            reserveBtn.Click += reserveBtn_Click;
            // 
            // bookAbout
            // 
            bookAbout.AutoSize = true;
            bookAbout.BackColor = Color.Transparent;
            bookAbout.Font = new Font("PP Hatton", 12F);
            bookAbout.ForeColor = Color.FromArgb(76, 76, 76);
            bookAbout.Location = new Point(229, 436);
            bookAbout.Name = "bookAbout";
            bookAbout.Size = new Size(88, 19);
            bookAbout.TabIndex = 13;
            bookAbout.Text = "Synopsis";
            bookAbout.Click += label2_Click_2;
            // 
            // bookDetails
            // 
            bookDetails.AutoEllipsis = true;
            bookDetails.AutoSize = true;
            bookDetails.BackColor = Color.Transparent;
            bookDetails.Font = new Font("Nourd-Regular", 10F);
            bookDetails.Location = new Point(3, 0);
            bookDetails.Name = "bookDetails";
            bookDetails.Size = new Size(738, 48);
            bookDetails.TabIndex = 15;
            bookDetails.Text = resources.GetString("bookDetails.Text");
            bookDetails.Click += bookDetails_Click;
            // 
            // authorDetails
            // 
            authorDetails.BackColor = Color.Transparent;
            authorDetails.Controls.Add(otherBooksList);
            authorDetails.Controls.Add(bookLikepercentage);
            authorDetails.Controls.Add(bookPublisher);
            authorDetails.Controls.Add(bookGenre);
            authorDetails.Controls.Add(bookSeries);
            authorDetails.Controls.Add(label1);
            authorDetails.Controls.Add(aboutBook);
            authorDetails.FlatStyle = FlatStyle.Flat;
            authorDetails.Location = new Point(699, 86);
            authorDetails.Name = "authorDetails";
            authorDetails.Size = new Size(274, 316);
            authorDetails.TabIndex = 16;
            authorDetails.TabStop = false;
            authorDetails.Enter += authorDetails_Enter;
            // 
            // otherBooksList
            // 
            otherBooksList.AutoScroll = true;
            otherBooksList.BackColor = Color.Transparent;
            otherBooksList.Controls.Add(otherBookCover);
            otherBooksList.DataSource = null;
            otherBooksList.Location = new Point(6, 193);
            otherBooksList.Name = "otherBooksList";
            otherBooksList.Size = new Size(260, 117);
            otherBooksList.TabIndex = 19;
            // 
            // otherBookCover
            // 
            otherBookCover.Image = Properties.Resources.book_placeholder;
            otherBookCover.Location = new Point(3, 3);
            otherBookCover.Name = "otherBookCover";
            otherBookCover.Size = new Size(70, 100);
            otherBookCover.SizeMode = PictureBoxSizeMode.StretchImage;
            otherBookCover.TabIndex = 26;
            otherBookCover.TabStop = false;
            // 
            // bookLikepercentage
            // 
            bookLikepercentage.AutoEllipsis = true;
            bookLikepercentage.Font = new Font("PP Hatton", 9F);
            bookLikepercentage.ForeColor = Color.FromArgb(76, 76, 76);
            bookLikepercentage.Location = new Point(6, 152);
            bookLikepercentage.Name = "bookLikepercentage";
            bookLikepercentage.Size = new Size(143, 18);
            bookLikepercentage.TabIndex = 17;
            bookLikepercentage.Text = "Liked: 100%";
            // 
            // bookPublisher
            // 
            bookPublisher.AutoEllipsis = true;
            bookPublisher.Font = new Font("Nourd-Regular", 10F);
            bookPublisher.Location = new Point(6, 56);
            bookPublisher.Name = "bookPublisher";
            bookPublisher.Size = new Size(260, 20);
            bookPublisher.TabIndex = 16;
            bookPublisher.Text = "Publisher Here";
            // 
            // bookGenre
            // 
            bookGenre.AutoEllipsis = true;
            bookGenre.Font = new Font("Nourd-Regular", 9F);
            bookGenre.Location = new Point(6, 111);
            bookGenre.Name = "bookGenre";
            bookGenre.Size = new Size(260, 30);
            bookGenre.TabIndex = 12;
            bookGenre.Text = "Genre Here";
            // 
            // bookSeries
            // 
            bookSeries.AutoEllipsis = true;
            bookSeries.Font = new Font("Nourd-Regular", 10F);
            bookSeries.Location = new Point(6, 76);
            bookSeries.Name = "bookSeries";
            bookSeries.Size = new Size(260, 20);
            bookSeries.TabIndex = 10;
            bookSeries.Text = "Series Name Here";
            bookSeries.Click += bookSeries_Click;
            // 
            // label1
            // 
            label1.Font = new Font("PP Hatton Italic", 9F);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.Location = new Point(6, 170);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 0;
            label1.Text = "Readers also enjoyed";
            // 
            // aboutBook
            // 
            aboutBook.AutoSize = true;
            aboutBook.Font = new Font("PP Hatton Italic", 12F);
            aboutBook.ForeColor = Color.FromArgb(76, 76, 76);
            aboutBook.Location = new Point(6, 19);
            aboutBook.Name = "aboutBook";
            aboutBook.Size = new Size(115, 21);
            aboutBook.TabIndex = 0;
            aboutBook.Text = "Book Details";
            aboutBook.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(200, 600);
            leftNavBar1.TabIndex = 17;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Location = new Point(205, 28);
            comp_Searchbar1.MainForm = null;
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(382, 35);
            comp_Searchbar1.TabIndex = 18;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(577, 23);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 44);
            comp_DateTime1.TabIndex = 19;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // bookImg
            // 
            bookImg.BackColor = Color.Gray;
            bookImg.Location = new Point(243, 129);
            bookImg.Name = "bookImg";
            bookImg.Size = new Size(180, 250);
            bookImg.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImg.TabIndex = 20;
            bookImg.TabStop = false;
            // 
            // ISBN
            // 
            ISBN.AutoEllipsis = true;
            ISBN.Font = new Font("Nourd-Regular", 8F);
            ISBN.Location = new Point(443, 232);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(205, 18);
            ISBN.TabIndex = 24;
            ISBN.Text = "ISBN Here";
            // 
            // customListView1
            // 
            customListView1.AutoScroll = true;
            customListView1.BackColor = Color.Transparent;
            customListView1.Controls.Add(bookDetails);
            customListView1.DataSource = null;
            customListView1.Location = new Point(229, 469);
            customListView1.Name = "customListView1";
            customListView1.Size = new Size(751, 119);
            customListView1.TabIndex = 26;
            // 
            // backBtn
            // 
            backBtn.AutoSize = true;
            backBtn.Font = new Font("PP Hatton", 9F);
            backBtn.ForeColor = Color.FromArgb(76, 76, 76);
            backBtn.Location = new Point(252, 92);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(116, 14);
            backBtn.TabIndex = 27;
            backBtn.Text = "Back to Library";
            backBtn.Click += backBtn_Click;
            // 
            // backIcon
            // 
            backIcon.Image = Properties.Resources.back;
            backIcon.Location = new Point(232, 92);
            backIcon.Name = "backIcon";
            backIcon.Size = new Size(14, 14);
            backIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            backIcon.TabIndex = 28;
            backIcon.TabStop = false;
            backIcon.Click += backIcon_Click;
            // 
            // BookPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(backIcon);
            Controls.Add(backBtn);
            Controls.Add(customListView1);
            Controls.Add(ISBN);
            Controls.Add(bookImg);
            Controls.Add(comp_Searchbar1);
            Controls.Add(leftNavBar1);
            Controls.Add(authorDetails);
            Controls.Add(bookAbout);
            Controls.Add(reserveBtn);
            Controls.Add(borrowBtn);
            Controls.Add(bookStatus);
            Controls.Add(statusText);
            Controls.Add(bookRating);
            Controls.Add(bookYear);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(bookImage);
            Controls.Add(comp_DateTime1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookPreview";
            Size = new Size(1000, 600);
            Load += BookPreview_Load;
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            authorDetails.ResumeLayout(false);
            authorDetails.PerformLayout();
            otherBooksList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)otherBookCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookImg).EndInit();
            customListView1.ResumeLayout(false);
            customListView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox bookImage;
        private Label bookTitle;
        private Label bookAuthor;
        private Label bookYear;
        private Label bookRating;
        private Label statusText;
        private Label bookStatus;
        private Button borrowBtn;
        private Button reserveBtn;
        private Label bookAbout;
        private Label bookDetails;
        private GroupBox authorDetails;
        private Label aboutBook;
        private Label label1;
        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_Searchbar comp_Searchbar1;
        private Components.Comp_DateTime comp_DateTime1;
        private ImageList imageList1;
        private PictureBox bookImg;
        private Label ratingtext;
        private Label bookSeries;
        private Label seriesText;
        private Label isbnText;
        private Label ISBN;
        private Label bookGenreText;
        private Label bookGenre;
        private Label bookPublisher;
        private Label publisherText;
        private Label bookLikepercentage;
        private Label likepercentageText;
        private Components.List.CustomListView otherBooksList;
        private PictureBox otherBookCover;
        private Components.List.CustomListView customListView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label backBtn;
        private PictureBox backIcon;
    }
}
