namespace HeronsNest.Components.Navigation
{
    partial class SideNavigation
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
            NavMenu = new Panel();
            NavBarControl = new LeftNavBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hamburger_menu;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += OnMenuClick;
            // 
            // NavMenu
            // 
            NavMenu.BackColor = SystemColors.ControlLightLight;
            NavMenu.Controls.Add(pictureBox1);
            NavMenu.Location = new Point(10, 9);
            NavMenu.Name = "NavMenu";
            NavMenu.Size = new Size(40, 40);
            NavMenu.TabIndex = 1;
            NavMenu.Click += OnMenuClick;
            // 
            // NavBarControl
            // 
            NavBarControl.BackColor = Color.White;
            NavBarControl.Location = new Point(0, 0);
            NavBarControl.Name = "NavBarControl";
            NavBarControl.Size = new Size(200, 600);
            NavBarControl.TabIndex = 2;
            // 
            // SideNavigation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(NavMenu);
            Controls.Add(NavBarControl);
            Name = "SideNavigation";
            Size = new Size(200, 600);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel NavMenu;
        private LeftNavBar NavBarControl;
    }
}
