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
            comp_Searchbar1 = new Components.Comp_Searchbar();
            cardListView = new Components.List.CustomListView();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(359, 119);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(82, 22);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += button1_Click;
            // 
            // myShelfTitle
            // 
            myShelfTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myShelfTitle.AutoSize = true;
            myShelfTitle.FlatStyle = FlatStyle.Flat;
            myShelfTitle.Font = new Font("PP Hatton", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myShelfTitle.ForeColor = Color.FromArgb(0, 149, 168);
            myShelfTitle.ImageAlign = ContentAlignment.MiddleLeft;
            myShelfTitle.Location = new Point(214, 119);
            myShelfTitle.Margin = new Padding(0);
            myShelfTitle.Name = "myShelfTitle";
            myShelfTitle.Size = new Size(142, 32);
            myShelfTitle.TabIndex = 2;
            myShelfTitle.Text = "My Shelf";
            myShelfTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // completedBooks
            // 
            completedBooks.AutoSize = true;
            completedBooks.Font = new Font("PP Hatton", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedBooks.ForeColor = Color.FromArgb(76, 76, 76);
            completedBooks.ImageAlign = ContentAlignment.MiddleLeft;
            completedBooks.Location = new Point(598, 176);
            completedBooks.Name = "completedBooks";
            completedBooks.Size = new Size(172, 19);
            completedBooks.TabIndex = 4;
            completedBooks.Text = "Completed Books";
            // 
            // pendingBooks
            // 
            pendingBooks.AutoSize = true;
            pendingBooks.Font = new Font("PP Hatton", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingBooks.ForeColor = Color.FromArgb(76, 76, 76);
            pendingBooks.ImageAlign = ContentAlignment.MiddleLeft;
            pendingBooks.Location = new Point(385, 177);
            pendingBooks.Name = "pendingBooks";
            pendingBooks.Size = new Size(145, 19);
            pendingBooks.TabIndex = 13;
            pendingBooks.Text = "Pending Books";
            // 
            // allBooks
            // 
            allBooks.AutoSize = true;
            allBooks.Font = new Font("PP Hatton", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allBooks.ForeColor = Color.FromArgb(76, 76, 76);
            allBooks.ImageAlign = ContentAlignment.MiddleLeft;
            allBooks.Location = new Point(217, 177);
            allBooks.Name = "allBooks";
            allBooks.Size = new Size(94, 19);
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
            comp_Searchbar1.MainForm = null;
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(382, 35);
            comp_Searchbar1.TabIndex = 21;
            // 
            // cardListView
            // 
            cardListView.DataSource = null;
            cardListView.Location = new Point(217, 214);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(760, 360);
            cardListView.TabIndex = 23;
            // 
            // MyShelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(cardListView);
            Controls.Add(comp_Searchbar1);
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
        private Components.Comp_Searchbar comp_Searchbar1;
        private Components.List.CustomListView cardListView;
    }
}
