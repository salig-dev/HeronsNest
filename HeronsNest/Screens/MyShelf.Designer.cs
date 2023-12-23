namespace HeronsNest.Screens
{
    partial class MyShelf
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            sideNavigation1 = new Components.Navigation.SideNavigation();
            bookCard1 = new Components.BookCard();
            bookCard2 = new Components.BookCard();
            bookCard3 = new Components.BookCard();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(240, 77);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 149, 168);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(48, 118);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 2;
            label2.Text = "My Shelf";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(340, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 3;
            label1.Text = "All Books";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(449, 77);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 4;
            label3.Text = "Pending Books";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(612, 77);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 5;
            label4.Text = "Borrowed Books";
            // 
            // sideNavigation1
            // 
            sideNavigation1.BackColor = Color.Transparent;
            sideNavigation1.Location = new Point(0, 0);
            sideNavigation1.Margin = new Padding(3, 5, 3, 5);
            sideNavigation1.Name = "sideNavigation1";
            sideNavigation1.Size = new Size(200, 600);
            sideNavigation1.TabIndex = 6;
            // 
            // bookCard1
            // 
            bookCard1.Location = new Point(16, 145);
            bookCard1.Margin = new Padding(3, 4, 3, 4);
            bookCard1.Name = "bookCard1";
<<<<<<< HEAD
            bookCard1.Size = new Size(223, 314);
            bookCard1.TabIndex = 0;
            bookCard1.Load += bookCard1_Load;
=======
            bookCard1.Size = new Size(400, 344);
            bookCard1.TabIndex = 7;
>>>>>>> 2d509392daa98bf29abe7e92c8a76c542dcc121f
            // 
            // bookCard2
            // 
            bookCard2.Location = new Point(340, 145);
            bookCard2.Margin = new Padding(3, 4, 3, 4);
            bookCard2.Name = "bookCard2";
<<<<<<< HEAD
            bookCard2.Size = new Size(223, 314);
            bookCard2.TabIndex = 1;
            bookCard2.Load += bookCard2_Load;
=======
            bookCard2.Size = new Size(400, 344);
            bookCard2.TabIndex = 8;
>>>>>>> 2d509392daa98bf29abe7e92c8a76c542dcc121f
            // 
            // bookCard3
            // 
            bookCard3.Location = new Point(660, 145);
            bookCard3.Margin = new Padding(3, 4, 3, 4);
            bookCard3.Name = "bookCard3";
            bookCard3.Size = new Size(400, 344);
            bookCard3.TabIndex = 9;
            // 
            // MyShelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(bookCard3);
            Controls.Add(bookCard2);
            Controls.Add(bookCard1);
            Controls.Add(sideNavigation1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "MyShelf";
            Size = new Size(1000, 600);
            Load += MyShelf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private Components.BookCard bookCard2;
        private Components.BookCard bookCard3;
        private Components.BookCard bookCard4;
        private Components.BookCard bookCard5;
        private Components.BookCard bookCard6;
        private Components.Navigation.SideNavigation sideNavigation1;
        private Components.BookCard bookCard1;
    }
}
