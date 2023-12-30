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
            leftNavBar1 = new Components.LeftNavBar();
            label1 = new Label();
            categoryListView = new Components.List.CustomListView();
            comp_Searchbar1 = new Components.Comp_Searchbar();
            SuspendLayout();
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(200, 600);
            leftNavBar1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(215, 82);
            label1.Name = "label1";
            label1.Size = new Size(267, 37);
            label1.TabIndex = 22;
            label1.Text = "Good Morning, User!";
            // 
            // categoryListView
            // 
            categoryListView.Anchor = AnchorStyles.None;
            categoryListView.AutoScroll = true;
            categoryListView.DataSource = null;
            categoryListView.FlowDirection = FlowDirection.TopDown;
            categoryListView.Location = new Point(215, 128);
            categoryListView.Name = "categoryListView";
            categoryListView.Size = new Size(769, 451);
            categoryListView.TabIndex = 24;
            categoryListView.WrapContents = false;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Location = new Point(215, 19);
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(769, 44);
            comp_Searchbar1.TabIndex = 25;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comp_Searchbar1);
            Controls.Add(categoryListView);
            Controls.Add(label1);
            Controls.Add(leftNavBar1);
            Name = "Home";
            Size = new Size(1000, 600);
            Load += OnScreenLoaded;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Components.LeftNavBar leftNavBar1;
        private Label label1;
        private Components.List.CustomListView categoryListView;
        private Components.Comp_Searchbar comp_Searchbar1;
    }
}
