namespace HeronsNest.Components.Home
{
    partial class CategoryListItem
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bookTitleLabel = new Label();
            authorInformationlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bookCardHome;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += OnCardClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Location = new Point(14, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += OnCardClicked;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoEllipsis = true;
            bookTitleLabel.BackColor = Color.White;
            bookTitleLabel.Font = new Font("PP Hatton", 10F);
            bookTitleLabel.ForeColor = Color.FromArgb(76, 76, 76);
            bookTitleLabel.Location = new Point(14, 213);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(160, 20);
            bookTitleLabel.TabIndex = 2;
            bookTitleLabel.Text = "Book Title";
            bookTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            bookTitleLabel.Click += bookTitleLabel_Click;
            // 
            // authorInformationlabel
            // 
            authorInformationlabel.AutoEllipsis = true;
            authorInformationlabel.BackColor = Color.White;
            authorInformationlabel.Font = new Font("Nourd-Regular", 8F);
            authorInformationlabel.Location = new Point(14, 235);
            authorInformationlabel.Name = "authorInformationlabel";
            authorInformationlabel.Size = new Size(160, 20);
            authorInformationlabel.TabIndex = 3;
            authorInformationlabel.Text = "Author, Year";
            authorInformationlabel.TextAlign = ContentAlignment.MiddleCenter;
            authorInformationlabel.Click += authorInformationlabel_Click;
            // 
            // CategoryListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(authorInformationlabel);
            Controls.Add(bookTitleLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CategoryListItem";
            Size = new Size(200, 280);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label bookTitleLabel;
        private Label authorInformationlabel;
    }
}
