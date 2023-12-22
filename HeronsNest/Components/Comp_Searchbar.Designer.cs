namespace HeronsNest.Components
{
    /// <summary>
    /// A custom search bar control for searching within categories.
    /// </summary>
    partial class Comp_Searchbar
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initializes the components of the search bar.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Category1", "Category2", "Category3" });
            cmbCategory.Location = new Point(23, 7);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(68, 28);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(91, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "   Search";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search_solid;
            btnSearch.Location = new Point(400, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(35, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Click += btnSearch_Click;
            // 
            // Comp_Searchbar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbCategory);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Comp_Searchbar";
            Size = new Size(450, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Handles the click event of the search button.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Handle the search button click event
            // Implement the search functionality here
        }
    }
}
