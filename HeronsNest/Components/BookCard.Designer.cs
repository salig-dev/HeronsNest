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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            bookTitle = new Label();
            bookAuthor = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            borrowedText = new Label();
            borrowedInfo = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            returnText = new Label();
            pictureBox10 = new PictureBox();
            returnDate = new Label();
            pictureBox11 = new PictureBox();
            borrowedBtn = new Button();
            returnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
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
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 300);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.Location = new Point(293, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 300);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(300, 10);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
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
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox7.Location = new Point(3, 19);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(300, 5);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox6.Location = new Point(165, -14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(5, 300);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
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
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox8.Location = new Point(13, 50);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(300, 5);
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox9.Location = new Point(3, 73);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(300, 5);
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
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
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox10.Location = new Point(3, 102);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(300, 5);
            pictureBox10.TabIndex = 15;
            pictureBox10.TabStop = false;
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
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox11.Location = new Point(13, 125);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(300, 20);
            pictureBox11.TabIndex = 17;
            pictureBox11.TabStop = false;
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
            Controls.Add(pictureBox11);
            Controls.Add(returnDate);
            Controls.Add(pictureBox10);
            Controls.Add(returnText);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(borrowedInfo);
            Controls.Add(borrowedText);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookCard";
            Size = new Size(316, 270);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label bookTitle;
        private Label bookAuthor;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label borrowedText;
        private Label borrowedInfo;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label returnText;
        private PictureBox pictureBox10;
        private Label returnDate;
        private PictureBox pictureBox11;
        private Button borrowedBtn;
        private Button returnBtn;
    }
}
