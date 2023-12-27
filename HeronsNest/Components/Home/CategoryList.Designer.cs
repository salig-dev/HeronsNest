namespace HeronsNest.Components.Home
{
    partial class CategoryList
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
            label1 = new Label();
            cardListView = new List.CustomListView();
            categoryListItem1 = new CategoryListItem();
            categoryListItem2 = new CategoryListItem();
            categoryListItem3 = new CategoryListItem();
            categoryListItem4 = new CategoryListItem();
            categoryListItem5 = new CategoryListItem();
            categoryListItem6 = new CategoryListItem();
            cardListView.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // cardListView
            // 
            cardListView.AutoScroll = true;
            cardListView.Controls.Add(categoryListItem1);
            cardListView.Controls.Add(categoryListItem2);
            cardListView.Controls.Add(categoryListItem3);
            cardListView.Controls.Add(categoryListItem4);
            cardListView.Controls.Add(categoryListItem5);
            cardListView.Controls.Add(categoryListItem6);
            cardListView.DataSource = null;
            cardListView.Location = new Point(15, 40);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(772, 237);
            cardListView.TabIndex = 1;
            cardListView.WrapContents = false;
            // 
            // categoryListItem1
            // 
            categoryListItem1.Location = new Point(3, 3);
            categoryListItem1.Name = "categoryListItem1";
            categoryListItem1.Size = new Size(150, 201);
            categoryListItem1.TabIndex = 0;
            // 
            // categoryListItem2
            // 
            categoryListItem2.Location = new Point(159, 3);
            categoryListItem2.Name = "categoryListItem2";
            categoryListItem2.Size = new Size(150, 201);
            categoryListItem2.TabIndex = 1;
            // 
            // categoryListItem3
            // 
            categoryListItem3.Location = new Point(315, 3);
            categoryListItem3.Name = "categoryListItem3";
            categoryListItem3.Size = new Size(150, 201);
            categoryListItem3.TabIndex = 2;
            // 
            // categoryListItem4
            // 
            categoryListItem4.Location = new Point(471, 3);
            categoryListItem4.Name = "categoryListItem4";
            categoryListItem4.Size = new Size(150, 201);
            categoryListItem4.TabIndex = 3;
            // 
            // categoryListItem5
            // 
            categoryListItem5.Location = new Point(627, 3);
            categoryListItem5.Name = "categoryListItem5";
            categoryListItem5.Size = new Size(150, 201);
            categoryListItem5.TabIndex = 4;
            // 
            // categoryListItem6
            // 
            categoryListItem6.Location = new Point(783, 3);
            categoryListItem6.Name = "categoryListItem6";
            categoryListItem6.Size = new Size(150, 201);
            categoryListItem6.TabIndex = 5;
            // 
            // CategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardListView);
            Controls.Add(label1);
            Name = "CategoryList";
            Size = new Size(800, 280);
            cardListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private List.CustomListView cardListView;
        private CategoryListItem categoryListItem1;
        private CategoryListItem categoryListItem2;
        private CategoryListItem categoryListItem3;
        private CategoryListItem categoryListItem4;
        private CategoryListItem categoryListItem5;
        private CategoryListItem categoryListItem6;
    }
}
