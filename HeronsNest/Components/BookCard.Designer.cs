namespace HeronsNest.Components
{
    partial class BookCard
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
            label7 = new Label();
            label6 = new Label();
            pictureBox19 = new PictureBox();
            bookName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 144);
            label7.Name = "label7";
            label7.Size = new Size(148, 13);
            label7.TabIndex = 36;
            label7.Text = "Submission Due: {DATE}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 132);
            label6.Name = "label6";
            label6.Size = new Size(131, 13);
            label6.TabIndex = 35;
            label6.Text = "Borrowed On: {DATE}";
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = SystemColors.ControlDarkDark;
            pictureBox19.Location = new Point(29, 36);
            pictureBox19.Margin = new Padding(3, 2, 3, 2);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(164, 94);
            pictureBox19.TabIndex = 34;
            pictureBox19.TabStop = false;
            // 
            // bookName
            // 
            bookName.AutoSize = true;
            bookName.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookName.Location = new Point(31, 10);
            bookName.Name = "bookName";
            bookName.Size = new Size(146, 13);
            bookName.TabIndex = 33;
            bookName.Text = "Book Title, Author Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 169);
            label1.Name = "label1";
            label1.Size = new Size(85, 13);
            label1.TabIndex = 37;
            label1.Text = "ISBN: {value}";
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox19);
            Controls.Add(bookName);
            Name = "BookCard";
            Size = new Size(223, 314);
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private PictureBox pictureBox19;
        private Label bookName;
        private Label label1;
    }
}
