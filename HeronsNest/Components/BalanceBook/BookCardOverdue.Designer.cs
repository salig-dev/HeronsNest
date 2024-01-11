namespace HeronsNest.Components
{
    partial class BookCardOverdue
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
            returnBtn = new Button();
            overdueBtn = new Button();
            returnDate = new Label();
            returnText = new Label();
            borrowedDate = new Label();
            borrowedText = new Label();
            bookAuthor = new Label();
            bookTitle = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookImage
            // 
            bookImage.BackColor = SystemColors.ControlDarkDark;
            bookImage.Location = new Point(14, 10);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(90, 130);
            bookImage.TabIndex = 30;
            bookImage.TabStop = false;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(247, 107, 86);
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("PP Hatton", 7F);
            returnBtn.ForeColor = Color.White;
            returnBtn.Location = new Point(114, 142);
            returnBtn.Margin = new Padding(3, 2, 3, 2);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(90, 30);
            returnBtn.TabIndex = 29;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            // 
            // overdueBtn
            // 
            overdueBtn.BackColor = Color.FromArgb(242, 62, 62);
            overdueBtn.FlatAppearance.BorderSize = 0;
            overdueBtn.FlatStyle = FlatStyle.Flat;
            overdueBtn.Font = new Font("PP Hatton", 7F);
            overdueBtn.ForeColor = Color.White;
            overdueBtn.Location = new Point(114, 108);
            overdueBtn.Margin = new Padding(3, 2, 3, 2);
            overdueBtn.Name = "overdueBtn";
            overdueBtn.Size = new Size(90, 30);
            overdueBtn.TabIndex = 28;
            overdueBtn.Text = "Overdue";
            overdueBtn.UseVisualStyleBackColor = false;
            // 
            // returnDate
            // 
            returnDate.AutoSize = true;
            returnDate.BackColor = Color.White;
            returnDate.Font = new Font("Nourd-Regular", 6F);
            returnDate.ForeColor = Color.FromArgb(116, 115, 115);
            returnDate.Location = new Point(114, 87);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(54, 10);
            returnDate.TabIndex = 27;
            returnDate.Text = "25 Dec 2023";
            // 
            // returnText
            // 
            returnText.AutoSize = true;
            returnText.BackColor = Color.White;
            returnText.Font = new Font("PP Hatton", 7F);
            returnText.ForeColor = Color.FromArgb(76, 76, 76);
            returnText.Location = new Point(114, 65);
            returnText.Name = "returnText";
            returnText.Size = new Size(61, 12);
            returnText.TabIndex = 26;
            returnText.Text = "Return by";
            // 
            // borrowedDate
            // 
            borrowedDate.AutoSize = true;
            borrowedDate.BackColor = Color.White;
            borrowedDate.Font = new Font("Nourd-Regular", 6F);
            borrowedDate.ForeColor = Color.FromArgb(116, 116, 115);
            borrowedDate.Location = new Point(114, 44);
            borrowedDate.Name = "borrowedDate";
            borrowedDate.Size = new Size(54, 10);
            borrowedDate.TabIndex = 25;
            borrowedDate.Text = "25 Dec 2023";
            // 
            // borrowedText
            // 
            borrowedText.AutoSize = true;
            borrowedText.BackColor = Color.White;
            borrowedText.Font = new Font("PP Hatton", 7F);
            borrowedText.ForeColor = Color.FromArgb(76, 76, 76);
            borrowedText.Location = new Point(114, 22);
            borrowedText.Name = "borrowedText";
            borrowedText.Size = new Size(83, 12);
            borrowedText.TabIndex = 24;
            borrowedText.Text = "Borrowed on";
            // 
            // bookAuthor
            // 
            bookAuthor.AutoEllipsis = true;
            bookAuthor.BackColor = Color.White;
            bookAuthor.Font = new Font("Nourd-Regular", 6F);
            bookAuthor.ForeColor = Color.FromArgb(116, 115, 115);
            bookAuthor.Location = new Point(14, 157);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(90, 10);
            bookAuthor.TabIndex = 23;
            bookAuthor.Text = "Author Name, Date";
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.BackColor = Color.White;
            bookTitle.FlatStyle = FlatStyle.Flat;
            bookTitle.Font = new Font("PP Hatton", 9F);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.Location = new Point(14, 142);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(90, 15);
            bookTitle.TabIndex = 22;
            bookTitle.Text = "Book Title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shelfCardOverdue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // BookCardOverdue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bookImage);
            Controls.Add(returnBtn);
            Controls.Add(overdueBtn);
            Controls.Add(returnDate);
            Controls.Add(returnText);
            Controls.Add(borrowedDate);
            Controls.Add(borrowedText);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(pictureBox1);
            Name = "BookCardOverdue";
            Size = new Size(225, 200);
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bookImage;
        private Button returnBtn;
        private Button overdueBtn;
        private Label returnDate;
        private Label returnText;
        private Label borrowedDate;
        private Label borrowedText;
        private Label bookAuthor;
        private Label bookTitle;
        private PictureBox pictureBox1;
    }
}
