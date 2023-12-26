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
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookRatingStars).BeginInit();
            SuspendLayout();
            // 
            // bookImage
            // 
            bookImage.Image = Properties.Resources.sampleBook;
            bookImage.Location = new Point(252, 133);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(130, 163);
            bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImage.TabIndex = 2;
            bookImage.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.Location = new Point(388, 133);
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
            bookAuthor.Location = new Point(388, 158);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(116, 18);
            bookAuthor.TabIndex = 4;
            bookAuthor.Text = "By Author Name";
            // 
            // bookYear
            // 
            bookYear.AutoSize = true;
            bookYear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookYear.Location = new Point(388, 176);
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
            bookRating.Location = new Point(388, 197);
            bookRating.Name = "bookRating";
            bookRating.Size = new Size(62, 18);
            bookRating.TabIndex = 6;
            bookRating.Text = "# Rating";
            bookRating.Click += bookRating_Click;
            // 
            // bookRatingStars
            // 
            bookRatingStars.Location = new Point(456, 197);
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
            statusText.Location = new Point(392, 237);
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
            bookStatus.Location = new Point(447, 235);
            bookStatus.Name = "bookStatus";
            bookStatus.Size = new Size(67, 20);
            bookStatus.TabIndex = 9;
            bookStatus.Text = "Available";
            // 
            // borrowBtn
            // 
            borrowBtn.Location = new Point(388, 262);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(148, 39);
            borrowBtn.TabIndex = 10;
            borrowBtn.Text = "BORROW";
            borrowBtn.UseVisualStyleBackColor = true;
            // 
            // reserveBtn
            // 
            reserveBtn.Location = new Point(542, 262);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(148, 39);
            reserveBtn.TabIndex = 11;
            reserveBtn.Text = "RESERVE";
            reserveBtn.UseVisualStyleBackColor = true;
            // 
            // bookAbout
            // 
            bookAbout.AutoSize = true;
            bookAbout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookAbout.Location = new Point(252, 349);
            bookAbout.Name = "bookAbout";
            bookAbout.Size = new Size(172, 25);
            bookAbout.TabIndex = 13;
            bookAbout.Text = "About The Book:";
            bookAbout.Click += label2_Click_2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(178, 88);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Back to Library";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // sideNavigation1
            // 
            // 
            // bookDetails
            // 
            bookDetails.AutoSize = true;
            bookDetails.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookDetails.Location = new Point(274, 374);
            bookDetails.Name = "bookDetails";
            bookDetails.Size = new Size(117, 18);
            bookDetails.TabIndex = 15;
            bookDetails.Text = "LOREM IPSUM ";
            // 
            // BookPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 247);
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
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookRatingStars).EndInit();
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
    }
}
