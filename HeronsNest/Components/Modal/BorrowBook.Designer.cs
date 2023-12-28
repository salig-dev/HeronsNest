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
            returnButtonborrow = new Label();
            FromMonthBorrow = new ComboBox();
            FromDayBorrow = new ComboBox();
            FromYearBorrow = new ComboBox();
            ToMonthBorrow = new ComboBox();
            ToDayBorrow = new ComboBox();
            ToYearBorrow = new ComboBox();
            fromBorrow = new Label();
            toBorrow = new Label();
            serialBorrow = new Label();
            textBox1 = new TextBox();
            verificationBorrow = new Label();
            SuspendLayout();
            // 
            // bookBorrow
            // 
            bookBorrow.Location = new Point(150, 295);
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
            borrowDetails.Location = new Point(152, 30);
            borrowDetails.Name = "borrowDetails";
            borrowDetails.Size = new Size(116, 21);
            borrowDetails.TabIndex = 1;
            borrowDetails.Text = "Fill Up Details";
            // 
            // returnButtonborrow
            // 
            returnButtonborrow.AutoSize = true;
            returnButtonborrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButtonborrow.Location = new Point(32, 30);
            returnButtonborrow.Name = "returnButtonborrow";
            returnButtonborrow.Size = new Size(27, 21);
            returnButtonborrow.TabIndex = 2;
            returnButtonborrow.Text = "<-";
            // 
            // FromMonthBorrow
            // 
            FromMonthBorrow.FormattingEnabled = true;
            FromMonthBorrow.Location = new Point(61, 107);
            FromMonthBorrow.Name = "FromMonthBorrow";
            FromMonthBorrow.Size = new Size(66, 23);
            FromMonthBorrow.TabIndex = 3;
            FromMonthBorrow.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // FromDayBorrow
            // 
            FromDayBorrow.FormattingEnabled = true;
            FromDayBorrow.Location = new Point(150, 107);
            FromDayBorrow.Name = "FromDayBorrow";
            FromDayBorrow.Size = new Size(66, 23);
            FromDayBorrow.TabIndex = 3;
            FromDayBorrow.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // FromYearBorrow
            // 
            FromYearBorrow.FormattingEnabled = true;
            FromYearBorrow.Location = new Point(238, 107);
            FromYearBorrow.Name = "FromYearBorrow";
            FromYearBorrow.Size = new Size(97, 23);
            FromYearBorrow.TabIndex = 3;
            FromYearBorrow.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // ToMonthBorrow
            // 
            ToMonthBorrow.FormattingEnabled = true;
            ToMonthBorrow.Location = new Point(61, 171);
            ToMonthBorrow.Name = "ToMonthBorrow";
            ToMonthBorrow.Size = new Size(66, 23);
            ToMonthBorrow.TabIndex = 3;
            ToMonthBorrow.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // ToDayBorrow
            // 
            ToDayBorrow.FormattingEnabled = true;
            ToDayBorrow.Location = new Point(150, 171);
            ToDayBorrow.Name = "ToDayBorrow";
            ToDayBorrow.Size = new Size(66, 23);
            ToDayBorrow.TabIndex = 3;
            ToDayBorrow.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // ToYearBorrow
            // 
            ToYearBorrow.FormattingEnabled = true;
            ToYearBorrow.Location = new Point(238, 171);
            ToYearBorrow.Name = "ToYearBorrow";
            ToYearBorrow.Size = new Size(97, 23);
            ToYearBorrow.TabIndex = 3;
            ToYearBorrow.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // fromBorrow
            // 
            fromBorrow.AutoSize = true;
            fromBorrow.Location = new Point(61, 78);
            fromBorrow.Name = "fromBorrow";
            fromBorrow.Size = new Size(35, 15);
            fromBorrow.TabIndex = 4;
            fromBorrow.Text = "From";
            fromBorrow.Click += this.fromBorrow_Click;
            // 
            // toBorrow
            // 
            toBorrow.AutoSize = true;
            toBorrow.Location = new Point(61, 144);
            toBorrow.Name = "toBorrow";
            toBorrow.Size = new Size(19, 15);
            toBorrow.TabIndex = 4;
            toBorrow.Text = "To";
            // 
            // serialBorrow
            // 
            serialBorrow.AutoSize = true;
            serialBorrow.Location = new Point(61, 216);
            serialBorrow.Name = "serialBorrow";
            serialBorrow.Size = new Size(87, 15);
            serialBorrow.TabIndex = 4;
            serialBorrow.Text = "Book Serial No.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 234);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 20);
            textBox1.TabIndex = 5;
            // 
            // verificationBorrow
            // 
            verificationBorrow.AutoSize = true;
            verificationBorrow.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verificationBorrow.Location = new Point(61, 257);
            verificationBorrow.Name = "verificationBorrow";
            verificationBorrow.Size = new Size(85, 13);
            verificationBorrow.TabIndex = 4;
            verificationBorrow.Text = "For Verification";
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(returnButtonborrow);
            Controls.Add(borrowDetails);
            Controls.Add(bookBorrow);
            Name = "BorrowBook";
            Size = new Size(420, 360);
            Load += this.BorrowBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bookBorrow;
        private Label borrowDetails;
        private Label returnButtonborrow;
        private ComboBox FromMonthBorrow;
        private ComboBox FromDayBorrow;
        private ComboBox FromYearBorrow;
        private ComboBox ToMonthBorrow;
        private ComboBox ToDayBorrow;
        private ComboBox ToYearBorrow;
        private Label fromBorrow;
        private Label toBorrow;
        private Label serialBorrow;
        private TextBox textBox1;
        private Label verificationBorrow;
    }
}
