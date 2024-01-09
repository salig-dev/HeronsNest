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
            iconButton1 = new IconButton();
            iconButton2 = new IconButton();
            iconButton3 = new IconButton();
            iconButton4 = new IconButton();
            userControl1 = new UserControl();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            customListView2 = new List.CustomListView();
            panel1 = new Panel();
            memoryOutOf = new Label();
            memPercentageLbl = new Label();
            label1 = new Label();
            iconButton5 = new IconButton();
            iconButton8 = new IconButton();
            customListView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            customListView2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customListView1
            // 
            customListView1.Anchor = AnchorStyles.Top;
            customListView1.Controls.Add(iconButton1);
            customListView1.Controls.Add(iconButton2);
            customListView1.Controls.Add(iconButton3);
            customListView1.Controls.Add(iconButton4);
            customListView1.DataSource = null;
            customListView1.FlowDirection = FlowDirection.TopDown;
            customListView1.Location = new Point(9, 110);
            customListView1.Name = "customListView1";
            customListView1.Size = new Size(188, 300);
            customListView1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.AutoSize = true;
            iconButton1.Image = Properties.Resources.house_solid;
            iconButton1.Location = new Point(10, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(95, 28);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Home";
            iconButton1.Click += HomeClicked;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.AutoSize = true;
            iconButton2.Image = Properties.Resources.magnifying_glass_solid;
            iconButton2.Location = new Point(8, 37);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(99, 28);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Search";
            iconButton2.Click += SearchClicked;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.None;
            iconButton3.AutoSize = true;
            iconButton3.Image = Properties.Resources.book_solid;
            iconButton3.Location = new Point(3, 71);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(109, 28);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "My Shelf";
            iconButton3.Click += MyShelfClicked;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.None;
            iconButton4.AutoSize = true;
            iconButton4.Image = Properties.Resources.money_bills_solid;
            iconButton4.Location = new Point(5, 105);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(104, 28);
            iconButton4.TabIndex = 3;
            iconButton4.Text = "Balance";
            iconButton4.Click += BalanceClicked;
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
            pictureBox1.Location = new Point(43, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 53);
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
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(customListView1, 0, 1);
            tableLayoutPanel1.Controls.Add(customListView2, 0, 2);
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
            customListView2.Controls.Add(panel1);
            customListView2.Controls.Add(iconButton5);
            customListView2.Controls.Add(iconButton8);
            customListView2.DataSource = null;
            customListView2.FlowDirection = FlowDirection.TopDown;
            customListView2.Location = new Point(9, 416);
            customListView2.Name = "customListView2";
            customListView2.Size = new Size(188, 173);
            customListView2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(memoryOutOf);
            panel1.Controls.Add(memPercentageLbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 60);
            panel1.TabIndex = 4;
            // 
            // memoryOutOf
            // 
            memoryOutOf.Location = new Point(7, 35);
            memoryOutOf.Name = "memoryOutOf";
            memoryOutOf.Size = new Size(166, 15);
            memoryOutOf.TabIndex = 2;
            memoryOutOf.Text = "10000 / 10000";
            memoryOutOf.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memPercentageLbl
            // 
            memPercentageLbl.AutoSize = true;
            memPercentageLbl.Location = new Point(150, 10);
            memPercentageLbl.Name = "memPercentageLbl";
            memPercentageLbl.Size = new Size(23, 15);
            memPercentageLbl.TabIndex = 1;
            memPercentageLbl.Text = "0%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Memory Usage";
            // 
            // iconButton5
            // 
            iconButton5.AutoSize = true;
            iconButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton5.Image = Properties.Resources.about_us_icon;
            iconButton5.Location = new Point(3, 69);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(148, 28);
            iconButton5.TabIndex = 0;
            iconButton5.Text = "About SaligTech";
            // 
            // iconButton8
            // 
            iconButton8.AutoSize = true;
            iconButton8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton8.Image = Properties.Resources.tandc;
            iconButton8.Location = new Point(3, 103);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(108, 28);
            iconButton8.TabIndex = 3;
            iconButton8.Text = "Log-Out";
            iconButton8.Load += iconButton8_Load;
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
            customListView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            customListView2.ResumeLayout(false);
            customListView2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private List.CustomListView customListView1;
        private UserControl userControl1;
        private IconButton iconButton1;
        private IconButton iconButton2;
        private IconButton iconButton3;
        private IconButton iconButton4;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private List.CustomListView customListView2;
        private IconButton iconButton5;
        private IconButton iconButton8;
        private Panel panel1;
        private Label memoryOutOf;
        private Label memPercentageLbl;
        private Label label1;
    }
}
