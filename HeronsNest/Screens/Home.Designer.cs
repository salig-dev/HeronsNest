namespace HeronsNest.Screens
{
    partial class Home
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
            greetingLabel = new Label();
            homeBox = new Components.List.CustomListView();
            comp_DateTime1 = new Components.Comp_DateTime();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            leftNavBar1 = new Components.LeftNavBar();
            SuspendLayout();
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("PP Hatton", 20F);
            greetingLabel.ForeColor = Color.FromArgb(82, 167, 133);
            greetingLabel.Location = new Point(215, 82);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(331, 32);
            greetingLabel.TabIndex = 22;
            greetingLabel.Text = "Good Morning, User!";
            // 
            // homeBox
            // 
            homeBox.Anchor = AnchorStyles.None;
            homeBox.AutoScroll = true;
            homeBox.DataSource = null;
            homeBox.FlowDirection = FlowDirection.TopDown;
            homeBox.Location = new Point(215, 128);
            homeBox.Name = "homeBox";
            homeBox.Size = new Size(769, 451);
            homeBox.TabIndex = 24;
            homeBox.WrapContents = false;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(672, 23);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(248, 44);
            comp_DateTime1.TabIndex = 26;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Location = new Point(216, 28);
            comp_Searchbar1.MainForm = null;
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(482, 35);
            comp_Searchbar1.TabIndex = 25;
            comp_Searchbar1.Load += comp_Searchbar1_Load;
            comp_Searchbar1.MouseDown += OnSearchEnter;
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(206, 648);
            leftNavBar1.TabIndex = 27;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(leftNavBar1);
            Controls.Add(comp_Searchbar1);
            Controls.Add(homeBox);
            Controls.Add(greetingLabel);
            Controls.Add(comp_DateTime1);
            Name = "Home";
            Size = new Size(1000, 600);
            Load += OnScreenLoaded;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label greetingLabel;
        private Components.List.CustomListView homeBox;
        private Components.Comp_DateTime comp_DateTime1;
        private Components.Comp_Searchbar comp_Searchbar1;
        private Components.LeftNavBar leftNavBar1;
    }
}
