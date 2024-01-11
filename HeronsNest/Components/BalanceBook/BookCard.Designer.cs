namespace HeronsNest.Components
{
    partial class BookCard
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
            bookTitle = new Label();
            bookAuthor = new Label();
            borrowedText = new Label();
            borrowedDate = new Label();
            returnText = new Label();
            returnDate = new Label();
            borrowedBtn = new Button();
            returnBtn = new Button();
            pictureBox1 = new PictureBox();
            bookImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            SuspendLayout();
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.BackColor = Color.White;
            bookTitle.FlatStyle = FlatStyle.Flat;
            bookTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.Location = new Point(14, 142);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(90, 15);
            bookTitle.TabIndex = 6;
            bookTitle.Text = "Book Title";
            // 
            // bookAuthor
            // 
            bookAuthor.AutoEllipsis = true;
            bookAuthor.BackColor = Color.White;
            bookAuthor.Font = new Font("Microsoft Sans Serif", 5.99999952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAuthor.ForeColor = Color.FromArgb(116, 115, 115);
            bookAuthor.Location = new Point(14, 157);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(90, 10);
            bookAuthor.TabIndex = 7;
            bookAuthor.Text = "Author Name, Date";
            // 
            // borrowedText
            // 
            borrowedText.AutoSize = true;
            borrowedText.BackColor = Color.White;
            borrowedText.Font = new Font("Microsoft Sans Serif", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedText.ForeColor = Color.FromArgb(76, 76, 76);
            borrowedText.Location = new Point(114, 22);
            borrowedText.Name = "borrowedText";
            borrowedText.Size = new Size(68, 12);
            borrowedText.TabIndex = 10;
            borrowedText.Text = "Borrowed on";
            // 
            // borrowedDate
            // 
            borrowedDate.AutoSize = true;
            borrowedDate.BackColor = Color.White;
            borrowedDate.Font = new Font("Microsoft Sans Serif", 5.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedDate.ForeColor = Color.FromArgb(116, 116, 115);
            borrowedDate.Location = new Point(114, 44);
            borrowedDate.Name = "borrowedDate";
            borrowedDate.Size = new Size(58, 9);
            borrowedDate.TabIndex = 11;
            borrowedDate.Text = "25 Dec 2023";
            // 
            // returnText
            // 
            returnText.AutoSize = true;
            returnText.BackColor = Color.White;
            returnText.Font = new Font("Microsoft Sans Serif", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnText.ForeColor = Color.FromArgb(76, 76, 76);
            returnText.Location = new Point(114, 65);
            returnText.Name = "returnText";
            returnText.Size = new Size(54, 12);
            returnText.TabIndex = 14;
            returnText.Text = "Return by";
            // 
            // returnDate
            // 
            returnDate.AutoSize = true;
            returnDate.BackColor = Color.White;
            returnDate.Font = new Font("Microsoft Sans Serif", 5.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnDate.ForeColor = Color.FromArgb(116, 115, 115);
            returnDate.Location = new Point(114, 87);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(58, 9);
            returnDate.TabIndex = 16;
            returnDate.Text = "25 Dec 2023";
            // 
            // borrowedBtn
            // 
            borrowedBtn.BackColor = Color.FromArgb(255, 128, 0);
            borrowedBtn.Enabled = false;
            borrowedBtn.FlatAppearance.BorderSize = 0;
            borrowedBtn.FlatStyle = FlatStyle.Flat;
            borrowedBtn.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedBtn.ForeColor = Color.White;
            borrowedBtn.Location = new Point(114, 108);
            borrowedBtn.Margin = new Padding(3, 2, 3, 2);
            borrowedBtn.Name = "borrowedBtn";
            borrowedBtn.Size = new Size(90, 30);
            borrowedBtn.TabIndex = 18;
            borrowedBtn.Text = "Borrowed";
            borrowedBtn.UseVisualStyleBackColor = false;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(82, 167, 133);
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Microsoft Sans Serif", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.White;
            returnBtn.Location = new Point(114, 142);
            returnBtn.Margin = new Padding(3, 2, 3, 2);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(90, 30);
            returnBtn.TabIndex = 19;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += OnActionButtonClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shelfCard;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bookImage
            // 
            bookImage.BackColor = SystemColors.ControlDarkDark;
            bookImage.Location = new Point(14, 10);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(90, 130);
            bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImage.TabIndex = 20;
            bookImage.TabStop = false;
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bookImage);
            Controls.Add(returnBtn);
            Controls.Add(borrowedBtn);
            Controls.Add(returnDate);
            Controls.Add(returnText);
            Controls.Add(borrowedDate);
            Controls.Add(borrowedText);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(pictureBox1);
            Name = "BookCard";
            Size = new Size(222, 191);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label bookTitle;
        private Label bookAuthor;
        private Label borrowedText;
        private Label borrowedDate;
        private Label returnText;
        private Label returnDate;
        private Button borrowedBtn;
        private Button returnBtn;
        private PictureBox pictureBox1;
        private PictureBox bookImage;
    }
}
