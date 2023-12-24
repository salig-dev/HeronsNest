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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card_active;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book_placeholder;
            pictureBox2.Location = new Point(29, 25);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Nourd-Bold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.Location = new Point(29, 208);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(76, 15);
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
            bookAuthor.Size = new Size(83, 10);
            bookAuthor.TabIndex = 7;
            bookAuthor.Text = "Author Name, Date";
            // 
            // borrowedText
            // 
            borrowedText.AutoSize = true;
            borrowedText.BackColor = Color.Transparent;
            borrowedText.Font = new Font("PP Hatton Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedText.ForeColor = Color.FromArgb(76, 76, 76);
            borrowedText.Location = new Point(181, 38);
            borrowedText.Name = "borrowedText";
            borrowedText.Size = new Size(98, 16);
            borrowedText.TabIndex = 10;
            borrowedText.Text = "Borrowed on";
            // 
            // borrowedInfo
            // 
            borrowedInfo.AutoSize = true;
            borrowedInfo.Font = new Font("Nourd-Bold", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowedInfo.ForeColor = Color.FromArgb(116, 116, 115);
            borrowedInfo.Location = new Point(181, 65);
            borrowedInfo.Name = "borrowedInfo";
            borrowedInfo.Size = new Size(65, 11);
            borrowedInfo.TabIndex = 11;
            borrowedInfo.Text = "25 Dec 2023";
            // 
            // returnText
            // 
            returnText.AutoSize = true;
            returnText.Font = new Font("PP Hatton Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnText.ForeColor = Color.FromArgb(76, 76, 76);
            returnText.Location = new Point(181, 92);
            returnText.Name = "returnText";
            returnText.Size = new Size(73, 16);
            returnText.TabIndex = 14;
            returnText.Text = "Return by";
            // 
            // returnDate
            // 
            returnDate.AutoSize = true;
            returnDate.Font = new Font("Nourd-Bold", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnDate.ForeColor = Color.FromArgb(116, 115, 115);
            returnDate.Location = new Point(181, 119);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(65, 11);
            returnDate.TabIndex = 16;
            returnDate.Text = "25 Dec 2023";
            // 
            // borrowedBtn
            // 
            borrowedBtn.BackColor = Color.FromArgb(0, 149, 168);
            borrowedBtn.Font = new Font("PP Hatton", 8F);
            borrowedBtn.ForeColor = Color.White;
            borrowedBtn.Location = new Point(181, 160);
            borrowedBtn.Margin = new Padding(3, 2, 3, 2);
            borrowedBtn.Name = "borrowedBtn";
            borrowedBtn.Size = new Size(106, 40);
            borrowedBtn.TabIndex = 18;
            borrowedBtn.Text = "Borrowed";
            borrowedBtn.UseVisualStyleBackColor = false;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(82, 167, 133);
            returnBtn.Font = new Font("PP Hatton", 8F);
            returnBtn.ForeColor = Color.White;
            returnBtn.Location = new Point(181, 204);
            returnBtn.Margin = new Padding(3, 2, 3, 2);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(106, 40);
            returnBtn.TabIndex = 19;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 270);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Red;
            pictureBox4.Location = new Point(293, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 270);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Red;
            pictureBox5.Location = new Point(-3, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(316, 20);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Red;
            pictureBox6.Location = new Point(-3, 253);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(319, 20);
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Red;
            pictureBox7.Location = new Point(165, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(10, 270);
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Red;
            pictureBox8.Location = new Point(-13, 57);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(316, 5);
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Red;
            pictureBox11.Location = new Point(0, 25);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(316, 10);
            pictureBox11.TabIndex = 28;
            pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Red;
            pictureBox9.Location = new Point(-3, 79);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(316, 10);
            pictureBox9.TabIndex = 29;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Red;
            pictureBox10.Location = new Point(-3, 111);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(316, 5);
            pictureBox10.TabIndex = 30;
            pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Red;
            pictureBox12.Location = new Point(0, 133);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(316, 10);
            pictureBox12.TabIndex = 31;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Red;
            pictureBox13.Location = new Point(-3, 200);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(178, 5);
            pictureBox13.TabIndex = 32;
            pictureBox13.TabStop = false;
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
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
            Name = "BookCard";
            Size = new Size(316, 300);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox11;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
    }
}
