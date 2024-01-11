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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comp_Searchbar));
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Nourd-Regular", 9F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "ISBN", "Book Title", "Author", "Category" });
            cmbCategory.Location = new Point(9, 6);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(147, 22);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbCategory.MouseDown += OnSearchBarClicked;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Nourd-Regular", 9F);
            txtSearch.Location = new Point(12, 18);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(272, 15);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += OnSearchInput;
            txtSearch.MouseDown += OnSearchBarClicked;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Window;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(264, 15);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(24, 20);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += OnSearchConfirm;
            btnSearch.MouseDown += OnSearchBarClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(162, -8);
            panel1.MaximumSize = new Size(300, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 43);
            panel1.TabIndex = 4;
            panel1.MouseDown += OnSearchBarClicked;
            // 
            // Comp_Searchbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(cmbCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Comp_Searchbar";
            Size = new Size(472, 35);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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

        private Panel panel1;
    }
}
