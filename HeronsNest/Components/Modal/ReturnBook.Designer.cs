namespace HeronsNest.Components.Modal
{
    partial class ReturnBook
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
            borrowDetails = new Label();
            toBorrow = new Label();
            fromBorrow = new Label();
            bookReturn = new Button();
            DaysPenalty = new TextBox();
            Penalty = new Label();
            label2 = new Label();
            BookBorrow = new TextBox();
            Dateborrow = new DateTimePicker();
            DateReturn = new DateTimePicker();
            label3 = new Label();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // borrowDetails
            // 
            borrowDetails.Font = new Font("PP Hatton", 12F);
            borrowDetails.ForeColor = Color.FromArgb(0, 149, 168);
            borrowDetails.Location = new Point(40, 33);
            borrowDetails.Name = "borrowDetails";
            borrowDetails.Size = new Size(279, 21);
            borrowDetails.TabIndex = 3;
            borrowDetails.Text = "Fill Up Details";
            borrowDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toBorrow
            // 
            toBorrow.AutoSize = true;
            toBorrow.Font = new Font("PP Hatton", 9F);
            toBorrow.ForeColor = Color.FromArgb(76, 76, 76);
            toBorrow.Location = new Point(41, 183);
            toBorrow.Name = "toBorrow";
            toBorrow.Size = new Size(106, 14);
            toBorrow.TabIndex = 15;
            toBorrow.Text = "Date Returned";
            toBorrow.TextAlign = ContentAlignment.TopCenter;
            toBorrow.Click += toBorrow_Click;
            // 
            // fromBorrow
            // 
            fromBorrow.AutoSize = true;
            fromBorrow.Font = new Font("PP Hatton", 9F);
            fromBorrow.ForeColor = Color.FromArgb(76, 76, 76);
            fromBorrow.Location = new Point(41, 129);
            fromBorrow.Name = "fromBorrow";
            fromBorrow.Size = new Size(113, 14);
            fromBorrow.TabIndex = 16;
            fromBorrow.Text = "Date Borrowed";
            // 
            // bookReturn
            // 
            bookReturn.BackColor = Color.FromArgb(0, 149, 168);
            bookReturn.FlatAppearance.BorderSize = 0;
            bookReturn.FlatStyle = FlatStyle.Flat;
            bookReturn.Font = new Font("PP Hatton", 10F);
            bookReturn.ForeColor = Color.White;
            bookReturn.Location = new Point(106, 350);
            bookReturn.Name = "bookReturn";
            bookReturn.Size = new Size(148, 34);
            bookReturn.TabIndex = 6;
            bookReturn.Text = "RETURN";
            bookReturn.UseVisualStyleBackColor = false;
            // 
            // DaysPenalty
            // 
            DaysPenalty.Location = new Point(41, 254);
            DaysPenalty.Multiline = true;
            DaysPenalty.Name = "DaysPenalty";
            DaysPenalty.Size = new Size(278, 20);
            DaysPenalty.TabIndex = 18;
            DaysPenalty.TextChanged += textBox2_TextChanged;
            // 
            // Penalty
            // 
            Penalty.AutoSize = true;
            Penalty.Font = new Font("PP Hatton", 9F);
            Penalty.ForeColor = Color.FromArgb(76, 76, 76);
            Penalty.Location = new Point(41, 237);
            Penalty.Name = "Penalty";
            Penalty.Size = new Size(57, 14);
            Penalty.TabIndex = 19;
            Penalty.Text = "Penalty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PP Hatton", 9F);
            label2.ForeColor = Color.FromArgb(76, 76, 76);
            label2.Location = new Point(41, 75);
            label2.Name = "label2";
            label2.Size = new Size(118, 14);
            label2.TabIndex = 20;
            label2.Text = "Book Borrowed";
            label2.Click += label2_Click;
            // 
            // BookBorrow
            // 
            BookBorrow.Location = new Point(41, 92);
            BookBorrow.Name = "BookBorrow";
            BookBorrow.Size = new Size(278, 23);
            BookBorrow.TabIndex = 21;
            // 
            // Dateborrow
            // 
            Dateborrow.Location = new Point(41, 146);
            Dateborrow.Name = "Dateborrow";
            Dateborrow.Size = new Size(278, 23);
            Dateborrow.TabIndex = 22;
            // 
            // DateReturn
            // 
            DateReturn.Location = new Point(41, 200);
            DateReturn.Name = "DateReturn";
            DateReturn.Size = new Size(278, 23);
            DateReturn.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nourd-Regular", 8F);
            label3.Location = new Point(41, 288);
            label3.Name = "label3";
            label3.Size = new Size(213, 13);
            label3.TabIndex = 24;
            label3.Text = "NOTE: 20 PHP for everyday past the due";
            // 
            // backBtn
            // 
            backBtn.Image = Properties.Resources.back;
            backBtn.Location = new Point(41, 33);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(14, 14);
            backBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            backBtn.TabIndex = 33;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backBtn);
            Controls.Add(label3);
            Controls.Add(DateReturn);
            Controls.Add(Dateborrow);
            Controls.Add(BookBorrow);
            Controls.Add(label2);
            Controls.Add(Penalty);
            Controls.Add(DaysPenalty);
            Controls.Add(toBorrow);
            Controls.Add(fromBorrow);
            Controls.Add(bookReturn);
            Controls.Add(borrowDetails);
            Name = "ReturnBook";
            Size = new Size(360, 420);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label borrowDetails;
        private Label toBorrow;
        private Label fromBorrow;
        private Button bookReturn;
        private TextBox DaysPenalty;
        private Label Penalty;
        private Label label2;
        private TextBox BookBorrow;
        private DateTimePicker Dateborrow;
        private DateTimePicker DateReturn;
        private Label label3;
        private PictureBox backBtn;
    }
}
