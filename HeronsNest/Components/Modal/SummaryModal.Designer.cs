namespace HeronsNest.Components.Modal
{
    partial class SummaryModal
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
            label = new Label();
            bookTitletext = new Label();
            BorrowerNameText = new Label();
            bookSerialNumberText = new Label();
            DueDateText = new Label();
            ReturnDateText = new Label();
            returnButtonsummary = new Label();
            proceedButton = new Button();
            bookTitle = new Label();
            bookSerialNumber = new Label();
            bookBorrowerName = new Label();
            bookDueDate = new Label();
            bookReturnHere = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(125, 12);
            label.Name = "label";
            label.Size = new Size(98, 25);
            label.TabIndex = 1;
            label.Text = "Summary";
            label.Click += this.label_Click;
            // 
            // bookTitletext
            // 
            bookTitletext.AutoSize = true;
            bookTitletext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitletext.Location = new Point(33, 70);
            bookTitletext.Name = "bookTitletext";
            bookTitletext.Size = new Size(91, 21);
            bookTitletext.TabIndex = 2;
            bookTitletext.Text = "Book Title:";
            bookTitletext.Click += this.label1_Click;
            // 
            // BorrowerNameText
            // 
            BorrowerNameText.AutoSize = true;
            BorrowerNameText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BorrowerNameText.Location = new Point(33, 147);
            BorrowerNameText.Name = "BorrowerNameText";
            BorrowerNameText.Size = new Size(134, 21);
            BorrowerNameText.TabIndex = 3;
            BorrowerNameText.Text = "Borrower Name:";
            BorrowerNameText.Click += this.BorrowerNameText_Click;
            // 
            // bookSerialNumberText
            // 
            bookSerialNumberText.AutoSize = true;
            bookSerialNumberText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookSerialNumberText.Location = new Point(33, 108);
            bookSerialNumberText.Name = "bookSerialNumberText";
            bookSerialNumberText.Size = new Size(168, 21);
            bookSerialNumberText.TabIndex = 4;
            bookSerialNumberText.Text = "Book Serial Number:";
            bookSerialNumberText.Click += this.bookSerialNumberText_Click;
            // 
            // DueDateText
            // 
            DueDateText.AutoSize = true;
            DueDateText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DueDateText.Location = new Point(33, 187);
            DueDateText.Name = "DueDateText";
            DueDateText.Size = new Size(85, 21);
            DueDateText.TabIndex = 5;
            DueDateText.Text = "Due Date:";
            // 
            // ReturnDateText
            // 
            ReturnDateText.AutoSize = true;
            ReturnDateText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnDateText.Location = new Point(33, 228);
            ReturnDateText.Name = "ReturnDateText";
            ReturnDateText.Size = new Size(105, 21);
            ReturnDateText.TabIndex = 6;
            ReturnDateText.Text = "Return Date:";
            // 
            // returnButtonsummary
            // 
            returnButtonsummary.AutoSize = true;
            returnButtonsummary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButtonsummary.Location = new Point(33, 16);
            returnButtonsummary.Name = "returnButtonsummary";
            returnButtonsummary.Size = new Size(27, 21);
            returnButtonsummary.TabIndex = 7;
            returnButtonsummary.Text = "<-";
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.FromArgb(0, 149, 168);
            proceedButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            proceedButton.ForeColor = Color.White;
            proceedButton.Location = new Point(103, 308);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(149, 43);
            proceedButton.TabIndex = 8;
            proceedButton.Text = "CONTINUE";
            proceedButton.UseVisualStyleBackColor = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Segoe UI", 10F);
            bookTitle.Location = new Point(125, 70);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(102, 19);
            bookTitle.TabIndex = 9;
            bookTitle.Text = "Book Title Here";
            bookTitle.Click += this.label1_Click_1;
            // 
            // bookSerialNumber
            // 
            bookSerialNumber.AutoSize = true;
            bookSerialNumber.Font = new Font("Segoe UI", 10F);
            bookSerialNumber.Location = new Point(207, 111);
            bookSerialNumber.Name = "bookSerialNumber";
            bookSerialNumber.Size = new Size(128, 19);
            bookSerialNumber.TabIndex = 10;
            bookSerialNumber.Text = "Serial Number Here";
            // 
            // bookBorrowerName
            // 
            bookBorrowerName.AutoSize = true;
            bookBorrowerName.Font = new Font("Segoe UI", 10F);
            bookBorrowerName.Location = new Point(173, 150);
            bookBorrowerName.Name = "bookBorrowerName";
            bookBorrowerName.Size = new Size(138, 19);
            bookBorrowerName.TabIndex = 11;
            bookBorrowerName.Text = "Borrower Name Here";
            // 
            // bookDueDate
            // 
            bookDueDate.AutoSize = true;
            bookDueDate.Font = new Font("Segoe UI", 10F);
            bookDueDate.Location = new Point(124, 189);
            bookDueDate.Name = "bookDueDate";
            bookDueDate.Size = new Size(100, 19);
            bookDueDate.TabIndex = 12;
            bookDueDate.Text = "Due Date Here";
            // 
            // bookReturnHere
            // 
            bookReturnHere.AutoSize = true;
            bookReturnHere.Font = new Font("Segoe UI", 10F);
            bookReturnHere.Location = new Point(144, 231);
            bookReturnHere.Name = "bookReturnHere";
            bookReturnHere.Size = new Size(116, 19);
            bookReturnHere.TabIndex = 13;
            bookReturnHere.Text = "Return Date Here";
            // 
            // SummaryModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bookReturnHere);
            Controls.Add(bookDueDate);
            Controls.Add(bookBorrowerName);
            Controls.Add(bookSerialNumber);
            Controls.Add(bookTitle);
            Controls.Add(proceedButton);
            Controls.Add(returnButtonsummary);
            Controls.Add(ReturnDateText);
            Controls.Add(DueDateText);
            Controls.Add(bookSerialNumberText);
            Controls.Add(BorrowerNameText);
            Controls.Add(bookTitletext);
            Controls.Add(label);
            Name = "SummaryModal";
            Size = new Size(360, 420);
            Load += this.SummaryModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        private Label bookTitletext;
        private Label BorrowerNameText;
        private Label bookSerialNumberText;
        private Label DueDateText;
        private Label ReturnDateText;
        private Label returnButtonsummary;
        private Button proceedButton;
        private Label bookTitle;
        private Label bookSerialNumber;
        private Label bookBorrowerName;
        private Label bookDueDate;
        private Label bookReturnHere;
    }
}
