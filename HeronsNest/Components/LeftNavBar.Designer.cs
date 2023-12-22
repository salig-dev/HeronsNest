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
            iconButton5 = new IconButton();
            iconButton6 = new IconButton();
            customListView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customListView1
            // 
            customListView1.Controls.Add(iconButton1);
            customListView1.Controls.Add(iconButton2);
            customListView1.Controls.Add(iconButton3);
            customListView1.Controls.Add(iconButton4);
            customListView1.DataSource = null;
            customListView1.FlowDirection = FlowDirection.TopDown;
            customListView1.Location = new Point(12, 136);
            customListView1.Name = "customListView1";
            customListView1.Size = new Size(188, 174);
            customListView1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton1.Image = Properties.Resources.house_solid;
            iconButton1.Location = new Point(3, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(91, 31);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Home";
            iconButton1.Load += iconButton1_Load;
            // 
            // iconButton2
            // 
            iconButton2.AutoSize = true;
            iconButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton2.Image = Properties.Resources.magnifying_glass_solid;
            iconButton2.Location = new Point(3, 40);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(95, 31);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Search";
            // 
            // iconButton3
            // 
            iconButton3.AutoSize = true;
            iconButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton3.Image = Properties.Resources.book_solid;
            iconButton3.Location = new Point(3, 77);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(105, 31);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "My Shelf";
            // 
            // iconButton4
            // 
            iconButton4.AutoSize = true;
            iconButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton4.Image = Properties.Resources.money_bills_solid;
            iconButton4.Location = new Point(3, 114);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(100, 31);
            iconButton4.TabIndex = 3;
            iconButton4.Text = "Balance";
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
            pictureBox1.Image = Properties.Resources.HERONS_NEST_LOGO_TXT_HORIZ;
            pictureBox1.Location = new Point(37, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // iconButton5
            // 
            iconButton5.AutoSize = true;
            iconButton5.Image = null;
            iconButton5.Location = new Point(-24, 477);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(93, 31);
            iconButton5.TabIndex = 2;
            iconButton5.Text = "About";
            iconButton5.Load += iconButton5_Load;
            // 
            // iconButton6
            // 
            iconButton6.AutoSize = true;
            iconButton6.Image = null;
            iconButton6.Location = new Point(-24, 506);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(173, 31);
            iconButton6.TabIndex = 3;
            iconButton6.Text = "Terms and Conditions";
            // 
            // LeftNavBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(iconButton6);
            Controls.Add(iconButton5);
            Controls.Add(pictureBox1);
            Controls.Add(customListView1);
            Name = "LeftNavBar";
            Size = new Size(200, 600);
            customListView1.ResumeLayout(false);
            customListView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private IconButton iconButton5;
        private IconButton iconButton6;
    }
}
