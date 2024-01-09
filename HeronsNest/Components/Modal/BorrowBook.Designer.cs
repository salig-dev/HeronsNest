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
            label3 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // bookBorrow
            // 
            bookBorrow.Location = new Point(127, 295);
            bookBorrow.Name = "bookBorrow";
            bookBorrow.Size = new Size(122, 34);
            bookBorrow.TabIndex = 0;
            bookBorrow.Text = "Borrow";
            bookBorrow.UseVisualStyleBackColor = true;
            // 
            // borrowDetails
            // 
            borrowDetails.AutoSize = true;
            borrowDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowDetails.Location = new Point(129, 30);
            borrowDetails.Name = "borrowDetails";
            borrowDetails.Size = new Size(116, 21);
            borrowDetails.TabIndex = 1;
            borrowDetails.Text = "Fill Up Details";
            // 
            // fromBorrow
            // 
            fromBorrow.AutoSize = true;
            fromBorrow.Location = new Point(38, 78);
            fromBorrow.Name = "fromBorrow";
            fromBorrow.Size = new Size(35, 15);
            fromBorrow.TabIndex = 4;
            fromBorrow.Text = "From";
            // 
            // toBorrow
            // 
            toBorrow.AutoSize = true;
            toBorrow.Location = new Point(38, 144);
            toBorrow.Name = "toBorrow";
            toBorrow.Size = new Size(19, 15);
            toBorrow.TabIndex = 4;
            toBorrow.Text = "To";
            // 
            // DateBorrow
            // 
            DateBorrow.Location = new Point(39, 102);
            DateBorrow.Name = "DateBorrow";
            DateBorrow.Size = new Size(273, 23);
            DateBorrow.TabIndex = 6;
            // 
            // DateReturn
            // 
            DateReturn.Location = new Point(39, 165);
            DateReturn.Name = "DateReturn";
            DateReturn.Size = new Size(273, 23);
            DateReturn.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(45, 199);
            label3.Name = "label3";
            label3.Size = new Size(174, 12);
            label3.TabIndex = 25;
            label3.Text = "Note: 20php for everyday past the due";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(26, 20);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(47, 40);
            btnReturn.TabIndex = 26;
            btnReturn.Text = "<-";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReturn);
            Controls.Add(label3);
            Controls.Add(DateReturn);
            Controls.Add(DateBorrow);
            Controls.Add(toBorrow);
            Controls.Add(fromBorrow);
            Controls.Add(borrowDetails);
            Controls.Add(bookBorrow);
            Name = "BorrowBook";
            Size = new Size(360, 420);
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
        private Label label3;
        private Button btnReturn;
    }
}
