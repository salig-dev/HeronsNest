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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookPreview));
            bookImage = new PictureBox();
            bookTitle = new Label();
            bookAuthor = new Label();
            bookYear = new Label();
            bookRating = new Label();
            bookRatingStars = new PictureBox();
            statusText = new Label();
            bookStatus = new Label();
            borrowBtn = new Button();
            reserveBtn = new Button();
            bookAbout = new Label();
            linkLabel1 = new LinkLabel();
            bookDetails = new Label();
            authorDetails = new GroupBox();
            label1 = new Label();
            Auth = new Label();
            authorName = new Label();
            aboutAuthor = new Label();
            otherbook4 = new PictureBox();
            otherbook3 = new PictureBox();
            otherbook2 = new PictureBox();
            otherbook1 = new PictureBox();
            leftNavBar1 = new Components.LeftNavBar();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookRatingStars).BeginInit();
            authorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)otherbook4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherbook3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherbook2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherbook1).BeginInit();
            SuspendLayout();
            // 
            // bookImage
            // 
            bookImage.BorderStyle = BorderStyle.FixedSingle;
            bookImage.Location = new Point(212, 138);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(164, 200);
            bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImage.TabIndex = 2;
            bookImage.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.Location = new Point(414, 138);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(184, 25);
            bookTitle.TabIndex = 3;
            bookTitle.Text = "Book Title Here....";
            bookTitle.Click += label2_Click;
            // 
            // bookAuthor
            // 
            bookAuthor.AutoSize = true;
            bookAuthor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookAuthor.Location = new Point(397, 161);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(116, 18);
            bookAuthor.TabIndex = 4;
            bookAuthor.Text = "By Author Name";
            // 
            // bookYear
            // 
            bookYear.AutoSize = true;
            bookYear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookYear.Location = new Point(397, 179);
            bookYear.Name = "bookYear";
            bookYear.Size = new Size(38, 18);
            bookYear.TabIndex = 5;
            bookYear.Text = "Year";
            bookYear.Click += label2_Click_1;
            // 
            // bookRating
            // 
            bookRating.AutoSize = true;
            bookRating.Font = new Font("Microsoft Sans Serif", 11.25F);
            bookRating.Location = new Point(397, 214);
            bookRating.Name = "bookRating";
            bookRating.Size = new Size(62, 18);
            bookRating.TabIndex = 6;
            bookRating.Text = "# Rating";
            bookRating.Click += bookRating_Click;
            // 
            // bookRatingStars
            // 
            bookRatingStars.BorderStyle = BorderStyle.FixedSingle;
            bookRatingStars.Location = new Point(465, 214);
            bookRatingStars.Name = "bookRatingStars";
            bookRatingStars.Size = new Size(130, 18);
            bookRatingStars.SizeMode = PictureBoxSizeMode.StretchImage;
            bookRatingStars.TabIndex = 7;
            bookRatingStars.TabStop = false;
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusText.Location = new Point(397, 244);
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
            bookStatus.Location = new Point(397, 270);
            bookStatus.Name = "bookStatus";
            bookStatus.Size = new Size(67, 20);
            bookStatus.TabIndex = 9;
            bookStatus.Text = "Available";
            // 
            // borrowBtn
            // 
            borrowBtn.Location = new Point(397, 304);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(129, 28);
            borrowBtn.TabIndex = 10;
            borrowBtn.Text = "BORROW";
            borrowBtn.UseVisualStyleBackColor = true;
            // 
            // reserveBtn
            // 
            reserveBtn.Location = new Point(531, 304);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(129, 28);
            reserveBtn.TabIndex = 11;
            reserveBtn.Text = "RESERVE";
            reserveBtn.UseVisualStyleBackColor = true;
            // 
            // bookAbout
            // 
            bookAbout.AutoSize = true;
            bookAbout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookAbout.Location = new Point(212, 439);
            bookAbout.Name = "bookAbout";
            bookAbout.Size = new Size(172, 25);
            bookAbout.TabIndex = 13;
            bookAbout.Text = "About The Book:";
            bookAbout.Click += label2_Click_2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(212, 100);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Back to Library";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // bookDetails
            // 
            bookDetails.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookDetails.Location = new Point(235, 477);
            bookDetails.Name = "bookDetails";
            bookDetails.Size = new Size(647, 53);
            bookDetails.TabIndex = 15;
            bookDetails.Text = resources.GetString("bookDetails.Text");
            bookDetails.Click += bookDetails_Click;
            // 
            // authorDetails
            // 
            authorDetails.BackColor = Color.White;
            authorDetails.Controls.Add(label1);
            authorDetails.Controls.Add(Auth);
            authorDetails.Controls.Add(authorName);
            authorDetails.Controls.Add(aboutAuthor);
            authorDetails.Controls.Add(otherbook4);
            authorDetails.Controls.Add(otherbook3);
            authorDetails.Controls.Add(otherbook2);
            authorDetails.Controls.Add(otherbook1);
            authorDetails.Location = new Point(694, 109);
            authorDetails.Name = "authorDetails";
            authorDetails.Size = new Size(279, 258);
            authorDetails.TabIndex = 16;
            authorDetails.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 152);
            label1.Name = "label1";
            label1.Size = new Size(74, 14);
            label1.TabIndex = 0;
            label1.Text = "Other Books";
            // 
            // Auth
            // 
            Auth.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Auth.Location = new Point(17, 65);
            Auth.Name = "Auth";
            Auth.Size = new Size(244, 87);
            Auth.TabIndex = 0;
            Auth.Text = resources.GetString("Auth.Text");
            // 
            // authorName
            // 
            authorName.AutoSize = true;
            authorName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorName.Location = new Point(17, 45);
            authorName.Name = "authorName";
            authorName.Size = new Size(95, 18);
            authorName.TabIndex = 0;
            authorName.Text = "Author Name";
            // 
            // aboutAuthor
            // 
            aboutAuthor.AutoSize = true;
            aboutAuthor.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutAuthor.Location = new Point(17, 19);
            aboutAuthor.Name = "aboutAuthor";
            aboutAuthor.Size = new Size(139, 26);
            aboutAuthor.TabIndex = 0;
            aboutAuthor.Text = "About Author";
            // 
            // otherbook4
            // 
            otherbook4.BorderStyle = BorderStyle.FixedSingle;
            otherbook4.Location = new Point(215, 169);
            otherbook4.Name = "otherbook4";
            otherbook4.Size = new Size(46, 67);
            otherbook4.SizeMode = PictureBoxSizeMode.StretchImage;
            otherbook4.TabIndex = 2;
            otherbook4.TabStop = false;
            // 
            // otherbook3
            // 
            otherbook3.BorderStyle = BorderStyle.FixedSingle;
            otherbook3.Location = new Point(151, 169);
            otherbook3.Name = "otherbook3";
            otherbook3.Size = new Size(46, 67);
            otherbook3.SizeMode = PictureBoxSizeMode.StretchImage;
            otherbook3.TabIndex = 2;
            otherbook3.TabStop = false;
            // 
            // otherbook2
            // 
            otherbook2.BorderStyle = BorderStyle.FixedSingle;
            otherbook2.Location = new Point(85, 169);
            otherbook2.Name = "otherbook2";
            otherbook2.Size = new Size(46, 67);
            otherbook2.SizeMode = PictureBoxSizeMode.StretchImage;
            otherbook2.TabIndex = 2;
            otherbook2.TabStop = false;
            // 
            // otherbook1
            // 
            otherbook1.BorderStyle = BorderStyle.FixedSingle;
            otherbook1.Location = new Point(17, 169);
            otherbook1.Name = "otherbook1";
            otherbook1.Size = new Size(46, 67);
            otherbook1.SizeMode = PictureBoxSizeMode.StretchImage;
            otherbook1.TabIndex = 2;
            otherbook1.TabStop = false;
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
            comp_Searchbar1.Location = new Point(212, 24);
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(607, 44);
            comp_Searchbar1.TabIndex = 18;
            // 
            // BookPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(comp_Searchbar1);
            Controls.Add(leftNavBar1);
            Controls.Add(authorDetails);
            Controls.Add(bookDetails);
            Controls.Add(bookAbout);
            Controls.Add(reserveBtn);
            Controls.Add(borrowBtn);
            Controls.Add(bookStatus);
            Controls.Add(statusText);
            Controls.Add(bookRatingStars);
            Controls.Add(bookRating);
            Controls.Add(bookYear);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(bookImage);
            Controls.Add(linkLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookPreview";
            Size = new Size(1000, 600);
            Load += BookPreview_Load;
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookRatingStars).EndInit();
            authorDetails.ResumeLayout(false);
            authorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)otherbook4).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherbook3).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherbook2).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherbook1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox bookImage;
        private Label bookTitle;
        private Label bookAuthor;
        private Label bookYear;
        private Label bookRating;
        private PictureBox bookRatingStars;
        private Label statusText;
        private Label bookStatus;
        private Button borrowBtn;
        private Button reserveBtn;
        private Label bookAbout;
        private LinkLabel linkLabel1;
        private Label bookDetails;
        private GroupBox authorDetails;
        private Label authorName;
        private Label aboutAuthor;
        private Label Auth;
        private PictureBox otherbook1;
        private Label label1;
        private PictureBox otherbook4;
        private PictureBox otherbook3;
        private PictureBox otherbook2;
        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_Searchbar comp_Searchbar1;
    }
}
