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
            timeTakenLabel = new Label();
            labelResults = new Label();
            memoryUsedLabel = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
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
            comp_Searchbar1.Location = new Point(215, 23);
            comp_Searchbar1.MainForm = null;
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(480, 35);
            comp_Searchbar1.TabIndex = 1;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(669, 19);
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
            searchResultLabel.Size = new Size(264, 37);
            searchResultLabel.TabIndex = 3;
            searchResultLabel.Text = "Use the Search Bar!";
            // 
            // cardListView
            // 
            cardListView.AutoScroll = true;
            cardListView.DataSource = null;
            cardListView.Location = new Point(225, 139);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(775, 446);
            cardListView.TabIndex = 4;
            // 
            // timeTakenLabel
            // 
            timeTakenLabel.AutoSize = true;
            timeTakenLabel.ForeColor = SystemColors.ControlDark;
            timeTakenLabel.Location = new Point(237, 113);
            timeTakenLabel.Name = "timeTakenLabel";
            timeTakenLabel.Size = new Size(87, 15);
            timeTakenLabel.TabIndex = 5;
            timeTakenLabel.Text = "Time Taken: 0.0";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.ForeColor = SystemColors.ControlDark;
            labelResults.Location = new Point(339, 113);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(56, 15);
            labelResults.TabIndex = 6;
            labelResults.Text = "Results: 0";
            // 
            // memoryUsedLabel
            // 
            memoryUsedLabel.AutoSize = true;
            memoryUsedLabel.ForeColor = SystemColors.ControlDark;
            memoryUsedLabel.Location = new Point(438, 113);
            memoryUsedLabel.Name = "memoryUsedLabel";
            memoryUsedLabel.Size = new Size(114, 15);
            memoryUsedLabel.TabIndex = 7;
            memoryUsedLabel.Text = "Memory Used: 0 MB";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(876, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(941, 83);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "Sort By...";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(memoryUsedLabel);
            Controls.Add(labelResults);
            Controls.Add(timeTakenLabel);
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
        private Label timeTakenLabel;
        private Label labelResults;
        private Label memoryUsedLabel;
        private ComboBox comboBox1;
        private Label label1;
    }
}
