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
            returnButtonborrow = new Label();
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
            SuspendLayout();
            // 
            // returnButtonborrow
            // 
            returnButtonborrow.AutoSize = true;
            returnButtonborrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButtonborrow.Location = new Point(40, 25);
            returnButtonborrow.Name = "returnButtonborrow";
            returnButtonborrow.Size = new Size(27, 21);
            returnButtonborrow.TabIndex = 4;
            returnButtonborrow.Text = "<-";
            // 
            // borrowDetails
            // 
            borrowDetails.AutoSize = true;
            borrowDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowDetails.Location = new Point(114, 25);
            borrowDetails.Name = "borrowDetails";
            borrowDetails.Size = new Size(116, 21);
            borrowDetails.TabIndex = 3;
            borrowDetails.Text = "Fill Up Details";
            // 
            // toBorrow
            // 
            toBorrow.AutoSize = true;
            toBorrow.Location = new Point(43, 203);
            toBorrow.Name = "toBorrow";
            toBorrow.Size = new Size(82, 15);
            toBorrow.TabIndex = 15;
            toBorrow.Text = "Date Returned";
            toBorrow.TextAlign = ContentAlignment.TopCenter;
            toBorrow.Click += toBorrow_Click;
            // 
            // fromBorrow
            // 
            fromBorrow.AutoSize = true;
            fromBorrow.Location = new Point(40, 141);
            fromBorrow.Name = "fromBorrow";
            fromBorrow.Size = new Size(85, 15);
            fromBorrow.TabIndex = 16;
            fromBorrow.Text = "Date Borrowed";
            // 
            // bookReturn
            // 
            bookReturn.Location = new Point(132, 352);
            bookReturn.Name = "bookReturn";
            bookReturn.Size = new Size(122, 34);
            bookReturn.TabIndex = 6;
            bookReturn.Text = "Return";
            bookReturn.UseVisualStyleBackColor = true;
            // 
            // DaysPenalty
            // 
            DaysPenalty.Location = new Point(43, 288);
            DaysPenalty.Multiline = true;
            DaysPenalty.Name = "DaysPenalty";
            DaysPenalty.Size = new Size(274, 20);
            DaysPenalty.TabIndex = 18;
            DaysPenalty.TextChanged += textBox2_TextChanged;
            // 
            // Penalty
            // 
            Penalty.AutoSize = true;
            Penalty.Location = new Point(43, 265);
            Penalty.Name = "Penalty";
            Penalty.Size = new Size(46, 15);
            Penalty.TabIndex = 19;
            Penalty.Text = "Penalty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 20;
            label2.Text = "Book Borrowed";
            label2.Click += label2_Click;
            // 
            // BookBorrow
            // 
            BookBorrow.Location = new Point(40, 101);
            BookBorrow.Name = "BookBorrow";
            BookBorrow.Size = new Size(277, 23);
            BookBorrow.TabIndex = 21;
            // 
            // Dateborrow
            // 
            Dateborrow.Location = new Point(40, 164);
            Dateborrow.Name = "Dateborrow";
            Dateborrow.Size = new Size(277, 23);
            Dateborrow.TabIndex = 22;
            // 
            // DateReturn
            // 
            DateReturn.Location = new Point(43, 226);
            DateReturn.Name = "DateReturn";
            DateReturn.Size = new Size(274, 23);
            DateReturn.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(48, 319);
            label3.Name = "label3";
            label3.Size = new Size(174, 12);
            label3.TabIndex = 24;
            label3.Text = "Note: 20php for everyday past the due";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(returnButtonborrow);
            Controls.Add(borrowDetails);
            Name = "ReturnBook";
            Size = new Size(360, 420);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label returnButtonborrow;
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
    }
}
