namespace HeronsNest.Components.Modal
{
    partial class BorrowBook
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
            bookBorrow = new Button();
            borrowDetails = new Label();
            fromBorrow = new Label();
            toBorrow = new Label();
            DateBorrow = new DateTimePicker();
            DateReturn = new DateTimePicker();
            actionMessageLbl = new Label();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // bookBorrow
            // 
            bookBorrow.BackColor = Color.FromArgb(0, 149, 168);
            bookBorrow.FlatAppearance.BorderSize = 0;
            bookBorrow.FlatStyle = FlatStyle.Flat;
            bookBorrow.Font = new Font("PP Hatton", 10F);
            bookBorrow.ForeColor = Color.White;
            bookBorrow.Location = new Point(112, 330);
            bookBorrow.Name = "bookBorrow";
            bookBorrow.Size = new Size(137, 34);
            bookBorrow.TabIndex = 0;
            bookBorrow.Text = "BORROW";
            bookBorrow.UseVisualStyleBackColor = false;
            bookBorrow.Click += OnReserve;
            // 
            // borrowDetails
            // 
            borrowDetails.Font = new Font("PP Hatton", 12F);
            borrowDetails.ForeColor = Color.FromArgb(0, 144, 163);
            borrowDetails.Location = new Point(112, 53);
            borrowDetails.Name = "borrowDetails";
            borrowDetails.Size = new Size(137, 21);
            borrowDetails.TabIndex = 1;
            borrowDetails.Text = "Fill Up Details";
            borrowDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fromBorrow
            // 
            fromBorrow.AutoSize = true;
            fromBorrow.Font = new Font("Nourd-Regular", 9F);
            fromBorrow.ForeColor = Color.FromArgb(76, 76, 76);
            fromBorrow.Location = new Point(31, 90);
            fromBorrow.Name = "fromBorrow";
            fromBorrow.Size = new Size(34, 14);
            fromBorrow.TabIndex = 4;
            fromBorrow.Text = "From";
            // 
            // toBorrow
            // 
            toBorrow.AutoSize = true;
            toBorrow.Font = new Font("Nourd-Regular", 9F);
            toBorrow.ForeColor = Color.FromArgb(76, 76, 76);
            toBorrow.Location = new Point(31, 149);
            toBorrow.Name = "toBorrow";
            toBorrow.Size = new Size(70, 14);
            toBorrow.TabIndex = 4;
            toBorrow.Text = "Return Until";
            // 
            // DateBorrow
            // 
            DateBorrow.Font = new Font("Nourd-Regular", 10F);
            DateBorrow.Location = new Point(31, 107);
            DateBorrow.Name = "DateBorrow";
            DateBorrow.Size = new Size(298, 23);
            DateBorrow.TabIndex = 6;
            DateBorrow.ValueChanged += OnDateValueChanged;
            // 
            // DateReturn
            // 
            DateReturn.Enabled = false;
            DateReturn.Font = new Font("Nourd-Regular", 10F);
            DateReturn.Location = new Point(31, 166);
            DateReturn.Name = "DateReturn";
            DateReturn.Size = new Size(298, 23);
            DateReturn.TabIndex = 7;
            // 
            // actionMessageLbl
            // 
            actionMessageLbl.Font = new Font("Microsoft Sans Serif", 8F);
            actionMessageLbl.Location = new Point(31, 208);
            actionMessageLbl.Name = "actionMessageLbl";
            actionMessageLbl.Size = new Size(298, 20);
            actionMessageLbl.TabIndex = 25;
            actionMessageLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            backBtn.Image = Properties.Resources.back;
            backBtn.Location = new Point(31, 53);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(14, 14);
            backBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            backBtn.TabIndex = 31;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(backBtn);
            Controls.Add(actionMessageLbl);
            Controls.Add(DateReturn);
            Controls.Add(DateBorrow);
            Controls.Add(toBorrow);
            Controls.Add(fromBorrow);
            Controls.Add(borrowDetails);
            Controls.Add(bookBorrow);
            Name = "BorrowBook";
            Size = new Size(360, 420);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bookBorrow;
        private Label borrowDetails;
        private Label fromBorrow;
        private Label toBorrow;
        private DateTimePicker DateBorrow;
        private DateTimePicker DateReturn;
        private Label actionMessageLbl;
        private PictureBox pictureBox5;
        private PictureBox btnReturn;
        private PictureBox backBtn;
    }
}
