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
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.card_active;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book_placeholder;
            pictureBox2.Location = new Point(7, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += this.pictureBox2_Click;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoEllipsis = true;
            bookTitleLabel.BackColor = SystemColors.ControlLightLight;
            bookTitleLabel.Font = new Font("Segoe UI", 12F);
            bookTitleLabel.Location = new Point(7, 123);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(134, 32);
            bookTitleLabel.TabIndex = 2;
            bookTitleLabel.Text = "Book Title";
            bookTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            bookTitleLabel.Click += bookTitleLabel_Click;
            // 
            // authorInformationlabel
            // 
            authorInformationlabel.AutoEllipsis = true;
            authorInformationlabel.BackColor = SystemColors.ControlLightLight;
            authorInformationlabel.Font = new Font("Segoe UI", 9F);
            authorInformationlabel.Location = new Point(7, 157);
            authorInformationlabel.Name = "authorInformationlabel";
            authorInformationlabel.Size = new Size(134, 31);
            authorInformationlabel.TabIndex = 3;
            authorInformationlabel.Text = "Author, Year";
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
            Size = new Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label bookTitleLabel;
        private Label authorInformationlabel;
    }
}
