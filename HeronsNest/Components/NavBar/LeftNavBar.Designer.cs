namespace HeronsNest.Components
{
    partial class LeftNavBar
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
            customListView1 = new List.CustomListView();
            homeButton = new IconButton();
            searchButton = new IconButton();
            myShelfButton = new IconButton();
            balanceButton = new IconButton();
            userControl1 = new UserControl();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            customListView2 = new List.CustomListView();
            iconButton5 = new IconButton();
            customListView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            customListView2.SuspendLayout();
            SuspendLayout();
            // 
            // customListView1
            // 
            customListView1.Controls.Add(homeButton);
            customListView1.Controls.Add(searchButton);
            customListView1.Controls.Add(myShelfButton);
            customListView1.Controls.Add(balanceButton);
            customListView1.DataSource = null;
            customListView1.Dock = DockStyle.Fill;
            customListView1.FlowDirection = FlowDirection.TopDown;
            customListView1.Location = new Point(3, 110);
            customListView1.Name = "customListView1";
            customListView1.Size = new Size(200, 300);
            customListView1.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.None;
            homeButton.Image = Properties.Resources.house_solid;
            homeButton.Location = new Point(3, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(150, 40);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.Click += HomeClicked;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.None;
            searchButton.Image = Properties.Resources.magnifying_glass_solid;
            searchButton.Location = new Point(3, 49);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 40);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.Click += SearchClicked;
            // 
            // myShelfButton
            // 
            myShelfButton.Anchor = AnchorStyles.None;
            myShelfButton.Image = Properties.Resources.book_solid;
            myShelfButton.Location = new Point(3, 95);
            myShelfButton.Name = "myShelfButton";
            myShelfButton.Size = new Size(150, 40);
            myShelfButton.TabIndex = 2;
            myShelfButton.Text = "My Shelf";
            myShelfButton.Click += MyShelfClicked;
            // 
            // balanceButton
            // 
            balanceButton.Anchor = AnchorStyles.None;
            balanceButton.Image = Properties.Resources.money_bills_solid;
            balanceButton.Location = new Point(3, 141);
            balanceButton.Name = "balanceButton";
            balanceButton.Size = new Size(150, 40);
            balanceButton.TabIndex = 3;
            balanceButton.Text = "Balance";
            balanceButton.Click += BalanceClicked;
            // 
            // userControl1
            // 
            userControl1.AutoSize = true;
            userControl1.Location = new Point(0, 0);
            userControl1.Name = "userControl1";
            userControl1.Size = new Size(150, 150);
            userControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.HERONS_NEST_LOGO_TXT_HORIZ;
            pictureBox1.Location = new Point(42, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(customListView1, 0, 1);
            tableLayoutPanel1.Controls.Add(customListView2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5594234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2283249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.21225F));
            tableLayoutPanel1.Size = new Size(206, 648);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // customListView2
            // 
            customListView2.Anchor = AnchorStyles.Top;
            customListView2.Controls.Add(iconButton5);
            customListView2.DataSource = null;
            customListView2.FlowDirection = FlowDirection.TopDown;
            customListView2.Location = new Point(3, 416);
            customListView2.Name = "customListView2";
            customListView2.Size = new Size(200, 173);
            customListView2.TabIndex = 4;
            // 
            // iconButton5
            // 
            iconButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton5.Image = Properties.Resources.about_us_icon;
            iconButton5.Location = new Point(3, 3);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(150, 40);
            iconButton5.TabIndex = 0;
            iconButton5.Text = "About Salig Tech";
            iconButton5.Click += iconButton5Clicked;
            // 
            // LeftNavBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "LeftNavBar";
            Size = new Size(206, 648);
            customListView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            customListView2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private List.CustomListView customListView1;
        private UserControl userControl1;
        private IconButton homeButton;
        private IconButton searchButton;
        private IconButton myShelfButton;
        private IconButton balanceButton;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private List.CustomListView customListView2;
        private IconButton iconButton5;
    }
}
