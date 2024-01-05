namespace HeronsNest.Components
{
    partial class BalanceBookCard
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
            bookStatus = new Label();
            returnBtn = new Button();
            penaltyVal = new Label();
            totalVal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookImage
            // 
            bookImage.Image = Properties.Resources.book_placeholder;
            bookImage.Location = new Point(26, 7);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(80, 110);
            bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImage.TabIndex = 3;
            bookImage.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.BackColor = Color.White;
            bookTitle.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.Location = new Point(138, 43);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(110, 30);
            bookTitle.TabIndex = 7;
            bookTitle.Text = "Book Title";
            // 
            // bookAuthor
            // 
            bookAuthor.AutoEllipsis = true;
            bookAuthor.BackColor = Color.White;
            bookAuthor.Font = new Font("PP Hatton Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAuthor.ForeColor = Color.FromArgb(76, 76, 76);
            bookAuthor.Location = new Point(138, 80);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(110, 20);
            bookAuthor.TabIndex = 8;
            bookAuthor.Text = "Author Name";
            // 
            // bookStatus
            // 
            bookStatus.AutoSize = true;
            bookStatus.BackColor = Color.White;
            bookStatus.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookStatus.ForeColor = Color.FromArgb(76, 76, 76);
            bookStatus.Location = new Point(277, 56);
            bookStatus.Name = "bookStatus";
            bookStatus.Size = new Size(59, 14);
            bookStatus.TabIndex = 16;
            bookStatus.Text = "{Status}";
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(0, 149, 168);
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.White;
            returnBtn.Location = new Point(552, 46);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(80, 40);
            returnBtn.TabIndex = 19;
            returnBtn.Text = "Return";
            returnBtn.UseVisualStyleBackColor = false;
            // 
            // penaltyVal
            // 
            penaltyVal.AutoSize = true;
            penaltyVal.BackColor = Color.White;
            penaltyVal.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penaltyVal.ForeColor = Color.FromArgb(76, 76, 76);
            penaltyVal.Location = new Point(391, 56);
            penaltyVal.Name = "penaltyVal";
            penaltyVal.Size = new Size(35, 14);
            penaltyVal.TabIndex = 20;
            penaltyVal.Text = "₱69";
            // 
            // totalVal
            // 
            totalVal.AutoSize = true;
            totalVal.BackColor = Color.White;
            totalVal.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalVal.ForeColor = Color.FromArgb(76, 76, 76);
            totalVal.Location = new Point(480, 56);
            totalVal.Name = "totalVal";
            totalVal.Size = new Size(35, 14);
            totalVal.TabIndex = 21;
            totalVal.Text = "₱69";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.balance_card1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(658, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BalanceBookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalVal);
            Controls.Add(penaltyVal);
            Controls.Add(returnBtn);
            Controls.Add(bookStatus);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(bookImage);
            Controls.Add(pictureBox1);
            Name = "BalanceBookCard";
            Size = new Size(700, 150);
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox bookImage;
        private Label bookTitle;
        private Label bookAuthor;
        private Label bookStatus;
        private Button returnBtn;
        private Label penaltyVal;
        private Label totalVal;
        private PictureBox pictureBox1;
    }
}
