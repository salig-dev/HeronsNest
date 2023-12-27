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
            pictureBox4 = new PictureBox();
            bookTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            returnBtn = new Button();
            penaltyVal = new Label();
            totalVal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.book_placeholder;
            pictureBox4.Location = new Point(26, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitle.Location = new Point(138, 43);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(74, 14);
            bookTitle.TabIndex = 7;
            bookTitle.Text = "Book Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PP Hatton Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.Location = new Point(138, 73);
            label1.Name = "label1";
            label1.Size = new Size(66, 13);
            label1.TabIndex = 8;
            label1.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PP Hatton Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(76, 76, 76);
            label2.Location = new Point(277, 56);
            label2.Name = "label2";
            label2.Size = new Size(59, 14);
            label2.TabIndex = 16;
            label2.Text = "{Status}";
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(0, 149, 168);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookTitle);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Name = "BalanceBookCard";
            Size = new Size(700, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox4;
        private Label bookTitle;
        private Label label1;
        private Label label2;
        private Button returnBtn;
        private Label penaltyVal;
        private Label totalVal;
        private PictureBox pictureBox1;
    }
}
