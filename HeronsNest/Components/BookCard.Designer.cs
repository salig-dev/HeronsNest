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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bookTitle = new Label();
            bookAuthor = new Label();
            borrowedText = new Label();
            borrowedInfo = new Label();
            returnText = new Label();
            returnDate = new Label();
            borrowedBtn = new Button();
            returnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card_active;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 270);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book_placeholder;
            pictureBox2.Location = new Point(29, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Nourd-Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.Location = new Point(29, 203);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(85, 18);
            bookTitle.TabIndex = 6;
            bookTitle.Text = "Book Title";
            // 
            // bookAuthor
            // 
            bookAuthor.AutoSize = true;
            bookAuthor.Font = new Font("Nourd-Bold", 5.99999952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAuthor.ForeColor = Color.FromArgb(116, 115, 115);
            bookAuthor.Location = new Point(29, 234);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(104, 12);
            bookAuthor.TabIndex = 7;
            bookAuthor.Text = "Author Name, Date";
            bookAuthor.Click += this.bookAuthor_Click;
            // 
            // borrowedText
            // 
            borrowedText.AutoSize = true;
            borrowedText.BackColor = Color.Transparent;
            borrowedText.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedText.ForeColor = Color.FromArgb(76, 76, 76);
            borrowedText.Location = new Point(176, 27);
            borrowedText.Name = "borrowedText";
            borrowedText.Size = new Size(115, 18);
            borrowedText.TabIndex = 10;
            borrowedText.Text = "Borrowed on";
            // 
            // borrowedInfo
            // 
            borrowedInfo.AutoSize = true;
            borrowedInfo.Font = new Font("Nourd-Bold", 5.99999952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedInfo.ForeColor = Color.FromArgb(116, 116, 115);
            borrowedInfo.Location = new Point(176, 58);
            borrowedInfo.Name = "borrowedInfo";
            borrowedInfo.Size = new Size(69, 12);
            borrowedInfo.TabIndex = 11;
            borrowedInfo.Text = "25 Dec 2023";
            // 
            // returnText
            // 
            returnText.AutoSize = true;
            returnText.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnText.ForeColor = Color.FromArgb(76, 76, 76);
            returnText.Location = new Point(176, 81);
            returnText.Name = "returnText";
            returnText.Size = new Size(87, 18);
            returnText.TabIndex = 14;
            returnText.Text = "Return by";
            // 
            // returnDate
            // 
            returnDate.AutoSize = true;
            returnDate.Font = new Font("Nourd-Bold", 5.99999952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnDate.ForeColor = Color.FromArgb(116, 115, 115);
            returnDate.Location = new Point(176, 110);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(69, 12);
            returnDate.TabIndex = 16;
            returnDate.Text = "25 Dec 2023";
            // 
            // borrowedBtn
            // 
            borrowedBtn.BackColor = Color.FromArgb(0, 149, 168);
            borrowedBtn.Font = new Font("PP Hatton", 8F);
            borrowedBtn.ForeColor = Color.White;
            borrowedBtn.Location = new Point(176, 151);
            borrowedBtn.Name = "borrowedBtn";
            borrowedBtn.Size = new Size(111, 40);
            borrowedBtn.TabIndex = 18;
            borrowedBtn.Text = "Borrowed";
            borrowedBtn.UseVisualStyleBackColor = false;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(82, 167, 133);
            returnBtn.Font = new Font("PP Hatton", 8F);
            returnBtn.ForeColor = Color.White;
            returnBtn.Location = new Point(176, 197);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(111, 40);
            returnBtn.TabIndex = 19;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(returnBtn);
            Controls.Add(borrowedBtn);
            Controls.Add(returnDate);
            Controls.Add(returnText);
            Controls.Add(borrowedInfo);
            Controls.Add(borrowedText);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookCard";
            Size = new Size(316, 270);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label bookTitle;
        private Label bookAuthor;
        private Label borrowedText;
        private Label borrowedInfo;
        private Label returnText;
        private Label returnDate;
        private Button borrowedBtn;
        private Button returnBtn;
    }
}
