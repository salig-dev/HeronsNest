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
            label3 = new Label();
            bookCard1 = new Components.BookCard();
            label1 = new Label();
            label4 = new Label();
            bookCard2 = new Components.BookCard();
            leftNavBar1 = new Components.LeftNavBar();
            comp_DateTime1 = new Components.Comp_DateTime();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(359, 121);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
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
            label2.Font = new Font("Microsoft Sans Serif", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 149, 168);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(214, 119);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 2;
            label2.Text = "My Shelf";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(76, 76, 76);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(598, 176);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 4;
            label3.Text = "Pending Books";
            // 
            // bookCard1
            // 
            bookCard1.Location = new Point(214, 225);
            bookCard1.Name = "bookCard1";
            bookCard1.Size = new Size(207, 187);
            bookCard1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(373, 177);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 13;
            label1.Text = "Borrowed Books";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(76, 76, 76);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(217, 177);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 14;
            label4.Text = "All Books";
            // 
            // bookCard2
            // 
            bookCard2.Location = new Point(427, 225);
            bookCard2.Name = "bookCard2";
            bookCard2.Size = new Size(214, 187);
            bookCard2.TabIndex = 18;
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(200, 600);
            leftNavBar1.TabIndex = 20;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(576, 25);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 44);
            comp_DateTime1.TabIndex = 22;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Location = new Point(211, 30);
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(382, 35);
            comp_Searchbar1.TabIndex = 21;
            // 
            // MyShelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(comp_Searchbar1);
            Controls.Add(leftNavBar1);
            Controls.Add(bookCard2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(bookCard1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comp_DateTime1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyShelf";
            Size = new Size(1000, 600);
            Load += MyShelf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
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
        private Components.BookCard bookCard4;
        private Components.BookCard bookCard5;
        private Components.BookCard bookCard6;
        private Components.BookCard bookCard1;
        private Label label1;
        private Label label4;
        private Components.BookCard bookCard2;
        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_DateTime comp_DateTime1;
        private Components.Comp_Searchbar comp_Searchbar1;
    }
}
