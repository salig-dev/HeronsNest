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
            panel2 = new Panel();
            dateText = new Label();
            pictureBox2 = new PictureBox();
            timeText = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Category1", "Category2", "Category3" });
            cmbCategory.Location = new Point(12, 14);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(64, 23);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(15, 18);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(272, 16);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Window;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(268, 16);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(24, 20);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(79, -2);
            panel1.MaximumSize = new Size(300, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 41);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(dateText);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(timeText);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(370, 5);
            panel2.MaximumSize = new Size(300, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 35);
            panel2.TabIndex = 5;
            // 
            // dateText
            // 
            dateText.AutoSize = true;
            dateText.BackColor = Color.Transparent;
            dateText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateText.Location = new Point(137, 13);
            dateText.Name = "dateText";
            dateText.Size = new Size(80, 15);
            dateText.TabIndex = 3;
            dateText.Text = "27 - 11 - 2023";
            dateText.TextAlign = ContentAlignment.MiddleCenter;
            dateText.Click += label1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 20);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // timeText
            // 
            timeText.AutoSize = true;
            timeText.BackColor = Color.Transparent;
            timeText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeText.Location = new Point(50, 12);
            timeText.Name = "timeText";
            timeText.Size = new Size(38, 15);
            timeText.TabIndex = 1;
            timeText.Text = "00:00";
            timeText.TextAlign = ContentAlignment.MiddleCenter;
            timeText.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Comp_Searchbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(cmbCategory);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Comp_Searchbar";
            Size = new Size(641, 44);
            Load += Comp_Searchbar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label timeText;
        private Label dateText;
        private PictureBox pictureBox2;
    }
}
