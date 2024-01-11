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
            leftNavBar1.Size = new Size(206, 648);
            leftNavBar1.TabIndex = 0;
            // 
            // comp_Searchbar1
            // 
            comp_Searchbar1.Font = new Font("Nourd-Regular", 9F);
            comp_Searchbar1.Location = new Point(215, 21);
            comp_Searchbar1.MainForm = null;
            comp_Searchbar1.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar1.Name = "comp_Searchbar1";
            comp_Searchbar1.Size = new Size(480, 33);
            comp_Searchbar1.TabIndex = 1;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Font = new Font("Nourd-Regular", 9F);
            comp_DateTime1.Location = new Point(698, 13);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 41);
            comp_DateTime1.TabIndex = 2;
            // 
            // searchResultLabel
            // 
            searchResultLabel.AutoEllipsis = true;
            searchResultLabel.Font = new Font("PP Hatton", 16F);
            searchResultLabel.ForeColor = Color.FromArgb(0, 149, 168);
            searchResultLabel.Location = new Point(225, 72);
            searchResultLabel.Name = "searchResultLabel";
            searchResultLabel.Size = new Size(470, 26);
            searchResultLabel.TabIndex = 3;
            searchResultLabel.Text = "Discover more with the search bar!";
            // 
            // cardListView
            // 
            cardListView.AutoScroll = true;
            cardListView.DataSource = null;
            cardListView.Location = new Point(225, 139);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(796, 446);
            cardListView.TabIndex = 4;
            // 
            // timeTakenLabel
            // 
            timeTakenLabel.AutoSize = true;
            timeTakenLabel.Font = new Font("Nourd-Regular", 8F);
            timeTakenLabel.ForeColor = SystemColors.ControlDark;
            timeTakenLabel.Location = new Point(225, 113);
            timeTakenLabel.Name = "timeTakenLabel";
            timeTakenLabel.Size = new Size(83, 13);
            timeTakenLabel.TabIndex = 5;
            timeTakenLabel.Text = "Time Taken: 0.0";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Font = new Font("Nourd-Regular", 8F);
            labelResults.ForeColor = SystemColors.ControlDark;
            labelResults.Location = new Point(370, 113);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(56, 13);
            labelResults.TabIndex = 6;
            labelResults.Text = "Results: 0";
            // 
            // memoryUsedLabel
            // 
            memoryUsedLabel.AutoSize = true;
            memoryUsedLabel.Font = new Font("Nourd-Regular", 8F);
            memoryUsedLabel.ForeColor = SystemColors.ControlDark;
            memoryUsedLabel.Location = new Point(488, 113);
            memoryUsedLabel.Name = "memoryUsedLabel";
            memoryUsedLabel.Size = new Size(108, 13);
            memoryUsedLabel.TabIndex = 7;
            memoryUsedLabel.Text = "Memory Used: 0 MB";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Nourd-Regular", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ISBN", "High to Low Ratings", "Low to High Ratings", "High to Low Likes", "Low to High Likes" });
            comboBox1.Location = new Point(876, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 22);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PP Hatton", 9F);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.Location = new Point(876, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 14);
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
