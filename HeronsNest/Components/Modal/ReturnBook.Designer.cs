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
            textBox1 = new TextBox();
            verificationBorrow = new Label();
            serialBorrow = new Label();
            toBorrow = new Label();
            fromBorrow = new Label();
            FromYearBorrow = new ComboBox();
            FromDayBorrow = new ComboBox();
            ToYearBorrow = new ComboBox();
            ToDayBorrow = new ComboBox();
            ToMonthBorrow = new ComboBox();
            FromMonthBorrow = new ComboBox();
            bookReturn = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // returnButtonborrow
            // 
            returnButtonborrow.AutoSize = true;
            returnButtonborrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButtonborrow.Location = new Point(66, 25);
            returnButtonborrow.Name = "returnButtonborrow";
            returnButtonborrow.Size = new Size(27, 21);
            returnButtonborrow.TabIndex = 4;
            returnButtonborrow.Text = "<-";
            // 
            // borrowDetails
            // 
            borrowDetails.AutoSize = true;
            borrowDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowDetails.Location = new Point(163, 25);
            borrowDetails.Name = "borrowDetails";
            borrowDetails.Size = new Size(116, 21);
            borrowDetails.TabIndex = 3;
            borrowDetails.Text = "Fill Up Details";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 241);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 20);
            textBox1.TabIndex = 17;
            // 
            // verificationBorrow
            // 
            verificationBorrow.AutoSize = true;
            verificationBorrow.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verificationBorrow.Location = new Point(43, 264);
            verificationBorrow.Name = "verificationBorrow";
            verificationBorrow.Size = new Size(85, 13);
            verificationBorrow.TabIndex = 13;
            verificationBorrow.Text = "For Verification";
            // 
            // serialBorrow
            // 
            serialBorrow.AutoSize = true;
            serialBorrow.Location = new Point(43, 223);
            serialBorrow.Name = "serialBorrow";
            serialBorrow.Size = new Size(87, 15);
            serialBorrow.TabIndex = 14;
            serialBorrow.Text = "Book Serial No.";
            // 
            // toBorrow
            // 
            toBorrow.AutoSize = true;
            toBorrow.Location = new Point(43, 151);
            toBorrow.Name = "toBorrow";
            toBorrow.Size = new Size(19, 15);
            toBorrow.TabIndex = 15;
            toBorrow.Text = "To";
            // 
            // fromBorrow
            // 
            fromBorrow.AutoSize = true;
            fromBorrow.Location = new Point(43, 85);
            fromBorrow.Name = "fromBorrow";
            fromBorrow.Size = new Size(35, 15);
            fromBorrow.TabIndex = 16;
            fromBorrow.Text = "From";
            // 
            // FromYearBorrow
            // 
            FromYearBorrow.FormattingEnabled = true;
            FromYearBorrow.Location = new Point(220, 114);
            FromYearBorrow.Name = "FromYearBorrow";
            FromYearBorrow.Size = new Size(97, 23);
            FromYearBorrow.TabIndex = 7;
            // 
            // FromDayBorrow
            // 
            FromDayBorrow.FormattingEnabled = true;
            FromDayBorrow.Location = new Point(132, 114);
            FromDayBorrow.Name = "FromDayBorrow";
            FromDayBorrow.Size = new Size(66, 23);
            FromDayBorrow.TabIndex = 8;
            // 
            // ToYearBorrow
            // 
            ToYearBorrow.FormattingEnabled = true;
            ToYearBorrow.Location = new Point(220, 178);
            ToYearBorrow.Name = "ToYearBorrow";
            ToYearBorrow.Size = new Size(97, 23);
            ToYearBorrow.TabIndex = 9;
            // 
            // ToDayBorrow
            // 
            ToDayBorrow.FormattingEnabled = true;
            ToDayBorrow.Location = new Point(132, 178);
            ToDayBorrow.Name = "ToDayBorrow";
            ToDayBorrow.Size = new Size(66, 23);
            ToDayBorrow.TabIndex = 10;
            // 
            // ToMonthBorrow
            // 
            ToMonthBorrow.FormattingEnabled = true;
            ToMonthBorrow.Location = new Point(43, 178);
            ToMonthBorrow.Name = "ToMonthBorrow";
            ToMonthBorrow.Size = new Size(66, 23);
            ToMonthBorrow.TabIndex = 11;
            // 
            // FromMonthBorrow
            // 
            FromMonthBorrow.FormattingEnabled = true;
            FromMonthBorrow.Location = new Point(43, 114);
            FromMonthBorrow.Name = "FromMonthBorrow";
            FromMonthBorrow.Size = new Size(66, 23);
            FromMonthBorrow.TabIndex = 12;
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
            // textBox2
            // 
            textBox2.Location = new Point(43, 307);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 20);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 289);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 19;
            label1.Text = "Penalty";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(verificationBorrow);
            Controls.Add(serialBorrow);
            Controls.Add(toBorrow);
            Controls.Add(fromBorrow);
            Controls.Add(FromYearBorrow);
            Controls.Add(FromDayBorrow);
            Controls.Add(ToYearBorrow);
            Controls.Add(ToDayBorrow);
            Controls.Add(ToMonthBorrow);
            Controls.Add(FromMonthBorrow);
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
        private TextBox textBox1;
        private Label verificationBorrow;
        private Label serialBorrow;
        private Label toBorrow;
        private Label fromBorrow;
        private ComboBox FromYearBorrow;
        private ComboBox FromDayBorrow;
        private ComboBox ToYearBorrow;
        private ComboBox ToDayBorrow;
        private ComboBox ToMonthBorrow;
        private ComboBox FromMonthBorrow;
        private Button bookReturn;
        private TextBox textBox2;
        private Label label1;
    }
}
