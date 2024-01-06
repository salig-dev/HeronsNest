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
            likepercentageText = new Label();
            bookLikepercentage = new Label();
            bookPublisher = new Label();
            publisherText = new Label();
            bookGenre = new Label();
            bookGenreText = new Label();
            bookSeries = new Label();
            seriesText = new Label();
            label1 = new Label();
            aboutBook = new Label();
            leftNavBar1 = new Components.LeftNavBar();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            comp_DateTime1 = new Components.Comp_DateTime();
            imageList1 = new ImageList(components);
            bookImg = new PictureBox();
            pictureBox1 = new PictureBox();
            ratingtext = new Label();
            bookIdText = new Label();
            BookId = new Label();
            ReturnToLibraryBtn = new Button();
            customListView1 = new Components.List.CustomListView();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            authorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookImage
            // 
            bookImage.Image = Properties.Resources.card_active;
            bookImage.Location = new Point(212, 138);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(164, 200);
            bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImage.TabIndex = 2;
            bookImage.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.ImageAlign = ContentAlignment.MiddleLeft;
            bookTitle.Location = new Point(394, 139);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(267, 25);
            bookTitle.TabIndex = 3;
            bookTitle.Text = "Book Title Here....";
            bookTitle.TextAlign = ContentAlignment.MiddleLeft;
            bookTitle.Click += label2_Click;
            // 
            // bookAuthor
            // 
            bookAuthor.AutoEllipsis = true;
            bookAuthor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookAuthor.Location = new Point(397, 164);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(263, 18);
            bookAuthor.TabIndex = 4;
            bookAuthor.Text = "By Author Name";
            // 
            // bookYear
            // 
            bookYear.AutoEllipsis = true;
            bookYear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookYear.Location = new Point(397, 183);
            bookYear.Name = "bookYear";
            bookYear.Size = new Size(267, 18);
            bookYear.TabIndex = 5;
            bookYear.Text = "Year";
            bookYear.Click += label2_Click_1;
            // 
            // bookRating
            // 
            bookRating.AutoSize = true;
            bookRating.Font = new Font("Microsoft Sans Serif", 11.25F);
            bookRating.Location = new Point(449, 240);
            bookRating.Name = "bookRating";
            bookRating.Size = new Size(86, 18);
            bookRating.TabIndex = 6;
            bookRating.Text = "Rating Here";
            bookRating.Click += bookRating_Click;
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusText.Location = new Point(397, 265);
            statusText.Name = "statusText";
            statusText.Size = new Size(58, 18);
            statusText.TabIndex = 8;
            statusText.Text = "Status: ";
            statusText.Click += statusText_Click;
            // 
            // bookStatus
            // 
            bookStatus.AutoSize = true;
            bookStatus.BackColor = Color.FromArgb(82, 167, 133);
            bookStatus.BorderStyle = BorderStyle.FixedSingle;
            bookStatus.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookStatus.Location = new Point(449, 265);
            bookStatus.Name = "bookStatus";
            bookStatus.Size = new Size(67, 20);
            bookStatus.TabIndex = 9;
            bookStatus.Text = "Available";
            // 
            // borrowBtn
            // 
            borrowBtn.Location = new Point(397, 293);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(129, 28);
            borrowBtn.TabIndex = 10;
            borrowBtn.Text = "BORROW";
            borrowBtn.UseVisualStyleBackColor = true;
            // 
            // reserveBtn
            // 
            reserveBtn.Location = new Point(531, 293);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(129, 28);
            reserveBtn.TabIndex = 11;
            reserveBtn.Text = "RESERVE";
            reserveBtn.UseVisualStyleBackColor = true;
            // 
            // bookAbout
            // 
            bookAbout.AutoSize = true;
            bookAbout.BackColor = Color.White;
            bookAbout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookAbout.Location = new Point(212, 405);
            bookAbout.Name = "bookAbout";
            bookAbout.Size = new Size(172, 25);
            bookAbout.TabIndex = 13;
            bookAbout.Text = "About The Book:";
            bookAbout.Click += label2_Click_2;
            // 
            // bookDetails
            // 
            bookDetails.AutoEllipsis = true;
            bookDetails.BackColor = Color.White;
            bookDetails.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookDetails.Location = new Point(224, 436);
            bookDetails.Name = "bookDetails";
            bookDetails.Size = new Size(692, 105);
            bookDetails.TabIndex = 15;
            bookDetails.Text = resources.GetString("bookDetails.Text");
            bookDetails.Click += bookDetails_Click;
            // 
            // authorDetails
            // 
            authorDetails.BackColor = Color.White;
            authorDetails.Controls.Add(customListView1);
            authorDetails.Controls.Add(likepercentageText);
            authorDetails.Controls.Add(bookLikepercentage);
            authorDetails.Controls.Add(bookPublisher);
            authorDetails.Controls.Add(publisherText);
            authorDetails.Controls.Add(bookGenre);
            authorDetails.Controls.Add(bookGenreText);
            authorDetails.Controls.Add(bookSeries);
            authorDetails.Controls.Add(seriesText);
            authorDetails.Controls.Add(label1);
            authorDetails.Controls.Add(aboutBook);
            authorDetails.Location = new Point(694, 109);
            authorDetails.Name = "authorDetails";
            authorDetails.Size = new Size(279, 262);
            authorDetails.TabIndex = 16;
            authorDetails.TabStop = false;
            authorDetails.Enter += authorDetails_Enter;
            // 
            // likepercentageText
            // 
            likepercentageText.AutoSize = true;
            likepercentageText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            likepercentageText.Location = new Point(17, 114);
            likepercentageText.Name = "likepercentageText";
            likepercentageText.Size = new Size(96, 18);
            likepercentageText.TabIndex = 18;
            likepercentageText.Text = "User Review:";
            // 
            // bookLikepercentage
            // 
            bookLikepercentage.AutoEllipsis = true;
            bookLikepercentage.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookLikepercentage.Location = new Point(109, 114);
            bookLikepercentage.Name = "bookLikepercentage";
            bookLikepercentage.Size = new Size(143, 18);
            bookLikepercentage.TabIndex = 17;
            bookLikepercentage.Text = "like percentage here";
            // 
            // bookPublisher
            // 
            bookPublisher.AutoEllipsis = true;
            bookPublisher.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookPublisher.Location = new Point(84, 51);
            bookPublisher.Name = "bookPublisher";
            bookPublisher.Size = new Size(168, 18);
            bookPublisher.TabIndex = 16;
            bookPublisher.Text = "publisher here";
            // 
            // publisherText
            // 
            publisherText.AutoSize = true;
            publisherText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publisherText.Location = new Point(17, 51);
            publisherText.Name = "publisherText";
            publisherText.Size = new Size(73, 18);
            publisherText.TabIndex = 14;
            publisherText.Text = "Publisher:";
            // 
            // bookGenre
            // 
            bookGenre.AutoEllipsis = true;
            bookGenre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookGenre.Location = new Point(65, 92);
            bookGenre.Name = "bookGenre";
            bookGenre.Size = new Size(188, 18);
            bookGenre.TabIndex = 12;
            bookGenre.Text = "genre here";
            // 
            // bookGenreText
            // 
            bookGenreText.AutoSize = true;
            bookGenreText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookGenreText.Location = new Point(17, 92);
            bookGenreText.Name = "bookGenreText";
            bookGenreText.Size = new Size(53, 18);
            bookGenreText.TabIndex = 11;
            bookGenreText.Text = "Genre:";
            // 
            // bookSeries
            // 
            bookSeries.AutoEllipsis = true;
            bookSeries.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookSeries.Location = new Point(66, 71);
            bookSeries.Name = "bookSeries";
            bookSeries.Size = new Size(188, 18);
            bookSeries.TabIndex = 10;
            bookSeries.Text = "series name here";
            bookSeries.Click += bookSeries_Click;
            // 
            // seriesText
            // 
            seriesText.AutoSize = true;
            seriesText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seriesText.Location = new Point(17, 71);
            seriesText.Name = "seriesText";
            seriesText.Size = new Size(58, 18);
            seriesText.TabIndex = 9;
            seriesText.Text = "Series: ";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 159);
            label1.Name = "label1";
            label1.Size = new Size(74, 14);
            label1.TabIndex = 0;
            label1.Text = "Other Books";
            // 
            // aboutBook
            // 
            aboutBook.AutoSize = true;
            aboutBook.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutBook.Location = new Point(17, 19);
            aboutBook.Name = "aboutBook";
            aboutBook.Size = new Size(135, 26);
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
            leftNavBar1.Size = new Size(194, 597);
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
            bookImg.Image = Properties.Resources.book_placeholder;
            bookImg.Location = new Point(224, 149);
            bookImg.Name = "bookImg";
            bookImg.Size = new Size(143, 172);
            bookImg.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImg.TabIndex = 20;
            bookImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.balance_card1;
            pictureBox1.Location = new Point(200, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(732, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // ratingtext
            // 
            ratingtext.AutoSize = true;
            ratingtext.Font = new Font("Microsoft Sans Serif", 11.25F);
            ratingtext.Location = new Point(397, 240);
            ratingtext.Name = "ratingtext";
            ratingtext.Size = new Size(54, 18);
            ratingtext.TabIndex = 22;
            ratingtext.Text = "Rating:";
            // 
            // bookIdText
            // 
            bookIdText.AutoSize = true;
            bookIdText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookIdText.Location = new Point(397, 201);
            bookIdText.Name = "bookIdText";
            bookIdText.Size = new Size(63, 18);
            bookIdText.TabIndex = 23;
            bookIdText.Text = "Book Id:";
            // 
            // BookId
            // 
            BookId.AutoEllipsis = true;
            BookId.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookId.Location = new Point(455, 201);
            BookId.Name = "BookId";
            BookId.Size = new Size(205, 18);
            BookId.TabIndex = 24;
            BookId.Text = "book ID here";
            // 
            // ReturnToLibraryBtn
            // 
            ReturnToLibraryBtn.Location = new Point(212, 73);
            ReturnToLibraryBtn.Name = "ReturnToLibraryBtn";
            ReturnToLibraryBtn.Size = new Size(129, 44);
            ReturnToLibraryBtn.TabIndex = 25;
            ReturnToLibraryBtn.Text = "<- Return To Library";
            ReturnToLibraryBtn.TextAlign = ContentAlignment.MiddleLeft;
            ReturnToLibraryBtn.UseVisualStyleBackColor = true;
            ReturnToLibraryBtn.Click += ReturnToLibraryBtn_Click;
            // 
            // customListView1
            // 
            customListView1.DataSource = null;
            customListView1.Location = new Point(17, 176);
            customListView1.Name = "customListView1";
            customListView1.Size = new Size(256, 80);
            customListView1.TabIndex = 19;
            // 
            // BookPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(ReturnToLibraryBtn);
            Controls.Add(BookId);
            Controls.Add(bookIdText);
            Controls.Add(ratingtext);
            Controls.Add(bookImg);
            Controls.Add(comp_Searchbar1);
            Controls.Add(leftNavBar1);
            Controls.Add(authorDetails);
            Controls.Add(bookDetails);
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
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookPreview";
            Size = new Size(1000, 600);
            Load += BookPreview_Load;
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            authorDetails.ResumeLayout(false);
            authorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label ratingtext;
        private Label bookSeries;
        private Label seriesText;
        private Label bookIdText;
        private Label BookId;
        private Label bookGenreText;
        private Label bookGenre;
        private Label bookPublisher;
        private Label publisherText;
        private Label bookLikepercentage;
        private Label likepercentageText;
        private Button ReturnToLibraryBtn;
        private Components.List.CustomListView customListView1;
    }
}
