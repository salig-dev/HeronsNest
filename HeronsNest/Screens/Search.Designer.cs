namespace HeronsNest.Screens
{
    partial class Search
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
            comp_Searchbar1 = new Components.Comp_Searchbar();
            comp_DateTime1 = new Components.Comp_DateTime();
            searchResultLabel = new Label();
            cardListView = new Components.List.CustomListView();
            SuspendLayout();
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(194, 600);
            leftNavBar1.TabIndex = 0;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Location = new Point(215, 15);
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(387, 35);
            comp_Searchbar1.TabIndex = 1;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(603, 9);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 44);
            comp_DateTime1.TabIndex = 2;
            // 
            // searchResultLabel
            // 
            searchResultLabel.AutoSize = true;
            searchResultLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            searchResultLabel.Location = new Point(225, 68);
            searchResultLabel.Name = "searchResultLabel";
            searchResultLabel.Size = new Size(368, 37);
            searchResultLabel.TabIndex = 3;
            searchResultLabel.Text = "Search Results for \"{DATA}\"";
            // 
            // cardListView
            // 
            cardListView.DataSource = null;
            cardListView.Location = new Point(225, 119);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(751, 466);
            cardListView.TabIndex = 4;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardListView);
            Controls.Add(searchResultLabel);
            Controls.Add(comp_DateTime1);
            Controls.Add(comp_Searchbar1);
            Controls.Add(leftNavBar1);
            Name = "Search";
            Size = new Size(1000, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.LeftNavBar leftNavBar1;
        private Components.Comp_Searchbar comp_Searchbar1;
        private Components.Comp_DateTime comp_DateTime1;
        private Label searchResultLabel;
        private Components.List.CustomListView cardListView;
    }
}
