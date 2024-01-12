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
            myShelfTitle = new Label();
            borrowedBooks = new Label();
            reservedBooks = new Label();
            allBooks = new Label();
            leftNavBar1 = new Components.LeftNavBar();
            comp_DateTime1 = new Components.Comp_DateTime();
            cardBox = new Components.List.CustomListView();
            shelfSearchBar = new Components.Comp_Searchbar();
            completedBooks = new Label();
            SuspendLayout();
            // 
            // myShelfTitle
            // 
            myShelfTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myShelfTitle.AutoSize = true;
            myShelfTitle.FlatStyle = FlatStyle.Flat;
            myShelfTitle.Font = new Font("PP Hatton", 20F);
            myShelfTitle.ForeColor = Color.FromArgb(0, 149, 168);
            myShelfTitle.ImageAlign = ContentAlignment.MiddleLeft;
            myShelfTitle.Location = new Point(217, 79);
            myShelfTitle.Margin = new Padding(0);
            myShelfTitle.Name = "myShelfTitle";
            myShelfTitle.Size = new Size(142, 32);
            myShelfTitle.TabIndex = 2;
            myShelfTitle.Text = "My Shelf";
            myShelfTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // borrowedBooks
            // 
            borrowedBooks.AutoSize = true;
            borrowedBooks.Cursor = Cursors.Hand;
            borrowedBooks.Font = new Font("PP Hatton", 12F);
            borrowedBooks.ForeColor = Color.FromArgb(76, 76, 76);
            borrowedBooks.ImageAlign = ContentAlignment.MiddleLeft;
            borrowedBooks.Location = new Point(514, 123);
            borrowedBooks.Name = "borrowedBooks";
            borrowedBooks.Size = new Size(163, 19);
            borrowedBooks.TabIndex = 4;
            borrowedBooks.Text = "Borrowed Books";
            borrowedBooks.Click += OnPendingBooksNavigate;
            // 
            // reservedBooks
            // 
            reservedBooks.AutoSize = true;
            reservedBooks.Cursor = Cursors.Hand;
            reservedBooks.Font = new Font("PP Hatton", 12F);
            reservedBooks.ForeColor = Color.FromArgb(76, 76, 76);
            reservedBooks.ImageAlign = ContentAlignment.MiddleLeft;
            reservedBooks.Location = new Point(341, 124);
            reservedBooks.Name = "reservedBooks";
            reservedBooks.Size = new Size(158, 19);
            reservedBooks.TabIndex = 13;
            reservedBooks.Text = "Reserved Books";
            reservedBooks.Click += OnReservedBooksNavigate;
            // 
            // allBooks
            // 
            allBooks.AutoSize = true;
            allBooks.Cursor = Cursors.Hand;
            allBooks.Font = new Font("PP Hatton", 12F);
            allBooks.ForeColor = Color.FromArgb(76, 76, 76);
            allBooks.ImageAlign = ContentAlignment.MiddleLeft;
            allBooks.Location = new Point(223, 124);
            allBooks.Name = "allBooks";
            allBooks.Size = new Size(94, 19);
            allBooks.TabIndex = 14;
            allBooks.Text = "All Books";
            allBooks.Click += OnAllBooksNavigate;
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(206, 648);
            leftNavBar1.TabIndex = 20;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Font = new Font("Nourd-Regular", 9F);
            comp_DateTime1.Location = new Point(728, 25);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 41);
            comp_DateTime1.TabIndex = 22;
            // 
            // cardBox
            // 
            cardBox.AutoScroll = true;
            cardBox.DataSource = null;
            cardBox.Font = new Font("Nourd-Regular", 9F);
            cardBox.Location = new Point(217, 211);
            cardBox.Name = "cardBox";
            cardBox.Size = new Size(760, 363);
            cardBox.TabIndex = 23;
            // 
            // shelfSearchBar
            // 
            shelfSearchBar.Font = new Font("Nourd-Regular", 9F);
            shelfSearchBar.Location = new Point(223, 158);
            shelfSearchBar.MainForm = null;
            shelfSearchBar.Margin = new Padding(3, 2, 3, 2);
            shelfSearchBar.Name = "shelfSearchBar";
            shelfSearchBar.Size = new Size(531, 33);
            shelfSearchBar.TabIndex = 24;
            // 
            // completedBooks
            // 
            completedBooks.AutoSize = true;
            completedBooks.Cursor = Cursors.Hand;
            completedBooks.Font = new Font("PP Hatton", 12F);
            completedBooks.ForeColor = Color.FromArgb(76, 76, 76);
            completedBooks.ImageAlign = ContentAlignment.MiddleLeft;
            completedBooks.Location = new Point(687, 123);
            completedBooks.Name = "completedBooks";
            completedBooks.Size = new Size(156, 19);
            completedBooks.TabIndex = 25;
            completedBooks.Text = "Returned Books";
            completedBooks.Click += OnCompletedBooksNavigate;
            // 
            // MyShelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(completedBooks);
            Controls.Add(shelfSearchBar);
            Controls.Add(cardBox);
            Controls.Add(leftNavBar1);
            Controls.Add(allBooks);
            Controls.Add(reservedBooks);
            Controls.Add(borrowedBooks);
            Controls.Add(myShelfTitle);
            Controls.Add(comp_DateTime1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyShelf";
            Size = new Size(1000, 600);
            Load += MyShelf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label myShelfTitle;
        private Label borrowedBooks;
        private Label reservedBooks;
        private Label allBooks;
        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_DateTime comp_DateTime1;
        private Components.List.CustomListView cardBox;
        private Components.Comp_Searchbar shelfSearchBar;
        private Label completedBooks;
    }
}
