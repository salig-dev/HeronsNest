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
            linkLabel1 = new LinkLabel();
            bookDetails = new Label();
            authorDetails = new GroupBox();
            label1 = new Label();
            authorAbt = new Label();
            authorName = new Label();
            aboutAuthor = new Label();
            otherbook4 = new PictureBox();
            otherbook3 = new PictureBox();
            otherbook2 = new PictureBox();
            otherbook1 = new PictureBox();
            leftNavBar1 = new Components.LeftNavBar();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            comp_DateTime1 = new Components.Comp_DateTime();
            imageList1 = new ImageList(components);
            bookImg = new PictureBox();
            pictureBox1 = new PictureBox();
            ratingtext = new Label();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            authorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)otherbook4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherbook3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherbook2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherbook1).BeginInit();
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
            bookTitle.Location = new Point(397, 138);
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
            bookRating.Location = new Point(449, 214);
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
            statusText.Location = new Point(397, 246);
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
            bookStatus.Location = new Point(449, 246);
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
            authorDetails.Controls.Add(label1);
            authorDetails.Controls.Add(authorAbt);
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
            // authorAbt
            // 
            authorAbt.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorAbt.Location = new Point(17, 65);
            authorAbt.Name = "authorAbt";
            authorAbt.Size = new Size(244, 87);
            authorAbt.TabIndex = 0;
            authorAbt.Text = resources.GetString("authorAbt.Text");
            // 
            // authorName
            // 
            authorName.AutoEllipsis = true;
            authorName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorName.Location = new Point(17, 45);
            authorName.Name = "authorName";
            authorName.Size = new Size(244, 18);
            authorName.TabIndex = 0;
            authorName.Text = "Author Name";
            // 
            // aboutAuthor
            // 
            aboutAuthor.AutoSize = true;
            aboutAuthor.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutAuthor.Location = new Point(17, 19);
            aboutAuthor.Name = "aboutAuthor";
            aboutAuthor.Size = new Size(187, 26);
            aboutAuthor.TabIndex = 0;
            aboutAuthor.Text = "About The Author:";
            aboutAuthor.TextAlign = ContentAlignment.MiddleLeft;
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
            ratingtext.Location = new Point(397, 214);
            ratingtext.Name = "ratingtext";
            ratingtext.Size = new Size(54, 18);
            ratingtext.TabIndex = 22;
            ratingtext.Text = "Rating:";
            // 
            // BookPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 247);
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
            Controls.Add(linkLabel1);
            Controls.Add(comp_DateTime1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookPreview";
            Size = new Size(1000, 600);
            Load += BookPreview_Load;
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            authorDetails.ResumeLayout(false);
            authorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)otherbook4).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherbook3).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherbook2).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherbook1).EndInit();
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
        private LinkLabel linkLabel1;
        private Label bookDetails;
        private GroupBox authorDetails;
        private Label authorName;
        private Label aboutAuthor;
        private Label authorAbt;
        private PictureBox otherbook1;
        private Label label1;
        private PictureBox otherbook4;
        private PictureBox otherbook3;
        private PictureBox otherbook2;
        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_Searchbar comp_Searchbar1;
        private Components.Comp_DateTime comp_DateTime1;
        private ImageList imageList1;
        private PictureBox bookImg;
        private PictureBox pictureBox1;
        private Label ratingtext;
    }
}
