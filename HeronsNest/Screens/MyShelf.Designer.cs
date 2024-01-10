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
            backBtn = new Button();
            myShelfTitle = new Label();
            completedBooks = new Label();
            pendingBooks = new Label();
            allBooks = new Label();
            leftNavBar1 = new Components.LeftNavBar();
            comp_DateTime1 = new Components.Comp_DateTime();
            cardListView = new Components.List.CustomListView();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(217, 30);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(129, 27);
            backBtn.TabIndex = 0;
            backBtn.Text = "<- Return to Library";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += button1_Click;
            // 
            // myShelfTitle
            // 
            myShelfTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myShelfTitle.AutoSize = true;
            myShelfTitle.FlatStyle = FlatStyle.Flat;
            myShelfTitle.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myShelfTitle.ForeColor = Color.FromArgb(0, 149, 168);
            myShelfTitle.ImageAlign = ContentAlignment.MiddleLeft;
            myShelfTitle.Location = new Point(217, 79);
            myShelfTitle.Margin = new Padding(0);
            myShelfTitle.Name = "myShelfTitle";
            myShelfTitle.Size = new Size(127, 31);
            myShelfTitle.TabIndex = 2;
            myShelfTitle.Text = "My Shelf";
            myShelfTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // completedBooks
            // 
            completedBooks.AutoSize = true;
            completedBooks.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedBooks.ForeColor = Color.FromArgb(76, 76, 76);
            completedBooks.ImageAlign = ContentAlignment.MiddleLeft;
            completedBooks.Location = new Point(604, 123);
            completedBooks.Name = "completedBooks";
            completedBooks.Size = new Size(150, 20);
            completedBooks.TabIndex = 4;
            completedBooks.Text = "Completed Books";
            // 
            // pendingBooks
            // 
            pendingBooks.AutoSize = true;
            pendingBooks.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingBooks.ForeColor = Color.FromArgb(76, 76, 76);
            pendingBooks.ImageAlign = ContentAlignment.MiddleLeft;
            pendingBooks.Location = new Point(391, 124);
            pendingBooks.Name = "pendingBooks";
            pendingBooks.Size = new Size(129, 20);
            pendingBooks.TabIndex = 13;
            pendingBooks.Text = "Pending Books";
            // 
            // allBooks
            // 
            allBooks.AutoSize = true;
            allBooks.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allBooks.ForeColor = Color.FromArgb(76, 76, 76);
            allBooks.ImageAlign = ContentAlignment.MiddleLeft;
            allBooks.Location = new Point(223, 124);
            allBooks.Name = "allBooks";
            allBooks.Size = new Size(84, 20);
            allBooks.TabIndex = 14;
            allBooks.Text = "All Books";
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
            comp_DateTime1.Location = new Point(728, 22);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 44);
            comp_DateTime1.TabIndex = 22;
            // 
            // cardListView
            // 
            cardListView.DataSource = null;
            cardListView.Location = new Point(217, 211);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(760, 363);
            cardListView.TabIndex = 23;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Location = new Point(223, 160);
            comp_Searchbar1.MainForm = null;
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(531, 35);
            comp_Searchbar1.TabIndex = 24;
            // 
            // MyShelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(comp_Searchbar1);
            Controls.Add(cardListView);
            Controls.Add(leftNavBar1);
            Controls.Add(allBooks);
            Controls.Add(pendingBooks);
            Controls.Add(completedBooks);
            Controls.Add(myShelfTitle);
            Controls.Add(backBtn);
            Controls.Add(comp_DateTime1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyShelf";
            Size = new Size(1000, 600);
            Load += MyShelf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Label myShelfTitle;
        private Label completedBooks;
        private Label pendingBooks;
        private Label allBooks;
        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_DateTime comp_DateTime1;
        private Components.List.CustomListView cardListView;
        private Components.Comp_Searchbar comp_Searchbar1;
    }
}
