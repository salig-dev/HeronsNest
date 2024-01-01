﻿namespace HeronsNest.Components.Home
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
            categoryLabel = new Label();
            cardListView = new List.CustomListView();
            SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 15F);
            categoryLabel.Location = new Point(10, 5);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(92, 28);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Category";
            // 
            // cardListView
            // 
            cardListView.AutoScroll = true;
            cardListView.DataSource = null;
            cardListView.Location = new Point(15, 40);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(772, 237);
            cardListView.TabIndex = 1;
            cardListView.WrapContents = false;
            // 
            // CategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardListView);
            Controls.Add(categoryLabel);
            Name = "CategoryList";
            Size = new Size(800, 280);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categoryLabel;
        private List.CustomListView cardListView;
    }
}
