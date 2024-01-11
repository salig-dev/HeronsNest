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
            summaryText = new Label();
            bookTitletext = new Label();
            BorrowerNameText = new Label();
            bookSerialNumberText = new Label();
            DueDateText = new Label();
            ReturnDateText = new Label();
            proceedButton = new Button();
            bookTitle = new Label();
            bookSerialNumber = new Label();
            bookBorrowerName = new Label();
            bookDueDate = new Label();
            bookReturnHere = new Label();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // summaryText
            // 
            summaryText.Font = new Font("PP Hatton", 12F);
            summaryText.ForeColor = Color.FromArgb(0, 149, 168);
            summaryText.Location = new Point(36, 33);
            summaryText.Name = "summaryText";
            summaryText.Size = new Size(288, 25);
            summaryText.TabIndex = 1;
            summaryText.Text = "Summary";
            summaryText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookTitletext
            // 
            bookTitletext.AutoSize = true;
            bookTitletext.Font = new Font("PP Hatton", 8F);
            bookTitletext.Location = new Point(36, 89);
            bookTitletext.Name = "bookTitletext";
            bookTitletext.Size = new Size(74, 13);
            bookTitletext.TabIndex = 2;
            bookTitletext.Text = "Book Title:";
            // 
            // BorrowerNameText
            // 
            BorrowerNameText.AutoSize = true;
            BorrowerNameText.Font = new Font("PP Hatton", 9F);
            BorrowerNameText.Location = new Point(36, 198);
            BorrowerNameText.Name = "BorrowerNameText";
            BorrowerNameText.Size = new Size(121, 14);
            BorrowerNameText.TabIndex = 3;
            BorrowerNameText.Text = "Borrower Name:";
            // 
            // bookSerialNumberText
            // 
            bookSerialNumberText.AutoSize = true;
            bookSerialNumberText.Font = new Font("PP Hatton", 9F);
            bookSerialNumberText.Location = new Point(36, 153);
            bookSerialNumberText.Name = "bookSerialNumberText";
            bookSerialNumberText.Size = new Size(150, 14);
            bookSerialNumberText.TabIndex = 4;
            bookSerialNumberText.Text = "Book Serial Number:";
            // 
            // DueDateText
            // 
            DueDateText.AutoSize = true;
            DueDateText.Font = new Font("PP Hatton", 9F);
            DueDateText.Location = new Point(36, 244);
            DueDateText.Name = "DueDateText";
            DueDateText.Size = new Size(74, 14);
            DueDateText.TabIndex = 5;
            DueDateText.Text = "Due Date:";
            // 
            // ReturnDateText
            // 
            ReturnDateText.AutoSize = true;
            ReturnDateText.Font = new Font("PP Hatton", 9F);
            ReturnDateText.Location = new Point(36, 289);
            ReturnDateText.Name = "ReturnDateText";
            ReturnDateText.Size = new Size(93, 14);
            ReturnDateText.TabIndex = 6;
            ReturnDateText.Text = "Return Date:";
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.FromArgb(0, 149, 168);
            proceedButton.FlatAppearance.BorderSize = 0;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("PP Hatton", 10F);
            proceedButton.ForeColor = Color.White;
            proceedButton.Location = new Point(106, 344);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(148, 40);
            proceedButton.TabIndex = 8;
            proceedButton.Text = "CONTINUE";
            proceedButton.UseVisualStyleBackColor = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.Font = new Font("Nourd-Regular", 9F);
            bookTitle.Location = new Point(36, 102);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(288, 40);
            bookTitle.TabIndex = 9;
            bookTitle.Text = "Book Title Here";
            // 
            // bookSerialNumber
            // 
            bookSerialNumber.Font = new Font("Nourd-Regular", 10F);
            bookSerialNumber.Location = new Point(36, 167);
            bookSerialNumber.Name = "bookSerialNumber";
            bookSerialNumber.Size = new Size(288, 20);
            bookSerialNumber.TabIndex = 10;
            bookSerialNumber.Text = "Serial Number Here";
            // 
            // bookBorrowerName
            // 
            bookBorrowerName.Font = new Font("Nourd-Regular", 10F);
            bookBorrowerName.Location = new Point(36, 213);
            bookBorrowerName.Name = "bookBorrowerName";
            bookBorrowerName.Size = new Size(288, 20);
            bookBorrowerName.TabIndex = 11;
            bookBorrowerName.Text = "Borrower Name Here";
            // 
            // bookDueDate
            // 
            bookDueDate.Font = new Font("Nourd-Regular", 10F);
            bookDueDate.Location = new Point(36, 258);
            bookDueDate.Name = "bookDueDate";
            bookDueDate.Size = new Size(288, 20);
            bookDueDate.TabIndex = 12;
            bookDueDate.Text = "Due Date Here";
            // 
            // bookReturnHere
            // 
            bookReturnHere.Font = new Font("Nourd-Regular", 10F);
            bookReturnHere.Location = new Point(36, 303);
            bookReturnHere.Name = "bookReturnHere";
            bookReturnHere.Size = new Size(288, 20);
            bookReturnHere.TabIndex = 13;
            bookReturnHere.Text = "Return Date Here";
            // 
            // backBtn
            // 
            backBtn.Image = Properties.Resources.back;
            backBtn.Location = new Point(36, 36);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(14, 14);
            backBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            backBtn.TabIndex = 34;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // SummaryModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backBtn);
            Controls.Add(bookReturnHere);
            Controls.Add(bookDueDate);
            Controls.Add(bookBorrowerName);
            Controls.Add(bookSerialNumber);
            Controls.Add(bookTitle);
            Controls.Add(proceedButton);
            Controls.Add(ReturnDateText);
            Controls.Add(DueDateText);
            Controls.Add(bookSerialNumberText);
            Controls.Add(BorrowerNameText);
            Controls.Add(bookTitletext);
            Controls.Add(summaryText);
            Name = "SummaryModal";
            Size = new Size(360, 420);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label summaryText;
        private Label bookTitletext;
        private Label BorrowerNameText;
        private Label bookSerialNumberText;
        private Label DueDateText;
        private Label ReturnDateText;
        private Button proceedButton;
        private Label bookTitle;
        private Label bookSerialNumber;
        private Label bookBorrowerName;
        private Label bookDueDate;
        private Label bookReturnHere;
        private PictureBox backBtn;
    }
}
