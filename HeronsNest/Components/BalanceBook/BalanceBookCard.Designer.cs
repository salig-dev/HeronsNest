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
            payBtn = new Button();
            penaltyVal = new Label();
            totalVal = new Label();
            balanceCard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balanceCard).BeginInit();
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
            bookTitle.Font = new Font("PP Hatton", 10F);
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
            bookAuthor.Font = new Font("PP Hatton", 8F);
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
            bookStatus.Font = new Font("PP Hatton", 10F);
            bookStatus.ForeColor = Color.FromArgb(76, 76, 76);
            bookStatus.Location = new Point(277, 56);
            bookStatus.Name = "bookStatus";
            bookStatus.Size = new Size(70, 17);
            bookStatus.TabIndex = 16;
            bookStatus.Text = "{Status}";
            // 
            // payBtn
            // 
            payBtn.BackColor = Color.FromArgb(0, 149, 168);
            payBtn.FlatAppearance.BorderSize = 0;
            payBtn.FlatStyle = FlatStyle.Flat;
            payBtn.Font = new Font("PP Hatton", 10F);
            payBtn.ForeColor = Color.White;
            payBtn.Location = new Point(552, 46);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(80, 40);
            payBtn.TabIndex = 19;
            payBtn.Text = "PAY";
            payBtn.UseVisualStyleBackColor = false;
            payBtn.Click += OnPayButtonClick;
            // 
            // penaltyVal
            // 
            penaltyVal.AutoSize = true;
            penaltyVal.BackColor = Color.White;
            penaltyVal.Font = new Font("PP Hatton", 10F);
            penaltyVal.ForeColor = Color.FromArgb(76, 76, 76);
            penaltyVal.Location = new Point(391, 56);
            penaltyVal.Name = "penaltyVal";
            penaltyVal.Size = new Size(41, 17);
            penaltyVal.TabIndex = 20;
            penaltyVal.Text = "₱69";
            // 
            // totalVal
            // 
            totalVal.AutoSize = true;
            totalVal.BackColor = Color.White;
            totalVal.Font = new Font("PP Hatton", 10F);
            totalVal.ForeColor = Color.FromArgb(76, 76, 76);
            totalVal.Location = new Point(480, 56);
            totalVal.Name = "totalVal";
            totalVal.Size = new Size(41, 17);
            totalVal.TabIndex = 21;
            totalVal.Text = "₱69";
            // 
            // balanceCard
            // 
            balanceCard.Image = Properties.Resources.balance_card1;
            balanceCard.Location = new Point(0, 0);
            balanceCard.Name = "balanceCard";
            balanceCard.Size = new Size(658, 133);
            balanceCard.SizeMode = PictureBoxSizeMode.AutoSize;
            balanceCard.TabIndex = 0;
            balanceCard.TabStop = false;
            balanceCard.Click += OnCardClicked;
            // 
            // BalanceBookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalVal);
            Controls.Add(penaltyVal);
            Controls.Add(payBtn);
            Controls.Add(bookStatus);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(bookImage);
            Controls.Add(balanceCard);
            Name = "BalanceBookCard";
            Size = new Size(670, 150);
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)balanceCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox bookImage;
        private Label bookTitle;
        private Label bookAuthor;
        private Label bookStatus;
        private Button payBtn;
        private Label penaltyVal;
        private Label totalVal;
        private PictureBox balanceCard;
    }
}
