namespace HeronsNest.Components
{
    partial class LoadMoreCard
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
            bookCard = new PictureBox();
            loadingAnim = new PictureBox();
            loadMoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)bookCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingAnim).BeginInit();
            SuspendLayout();
            // 
            // bookCard
            // 
            bookCard.Image = Properties.Resources.bookCardHome;
            bookCard.Location = new Point(0, 0);
            bookCard.Name = "bookCard";
            bookCard.Size = new Size(188, 268);
            bookCard.SizeMode = PictureBoxSizeMode.AutoSize;
            bookCard.TabIndex = 1;
            bookCard.TabStop = false;
            bookCard.Click += bookCard_Click;
            // 
            // loadingAnim
            // 
            loadingAnim.BackColor = Color.Gray;
            loadingAnim.Image = Properties.Resources.loading;
            loadingAnim.Location = new Point(14, 10);
            loadingAnim.Name = "loadingAnim";
            loadingAnim.Size = new Size(160, 200);
            loadingAnim.SizeMode = PictureBoxSizeMode.AutoSize;
            loadingAnim.TabIndex = 2;
            loadingAnim.TabStop = false;
            loadingAnim.Click += loadingAnim_Click;
            // 
            // loadMoreText
            // 
            loadMoreText.BackColor = Color.White;
            loadMoreText.Font = new Font("PP Hatton", 10F);
            loadMoreText.ForeColor = Color.FromArgb(76, 76, 76);
            loadMoreText.Location = new Point(16, 215);
            loadMoreText.Name = "loadMoreText";
            loadMoreText.Size = new Size(160, 20);
            loadMoreText.TabIndex = 3;
            loadMoreText.Text = "Load More...";
            loadMoreText.TextAlign = ContentAlignment.MiddleCenter;
            loadMoreText.Click += loadMoreText_Click;
            // 
            // LoadMoreCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(loadMoreText);
            Controls.Add(loadingAnim);
            Controls.Add(bookCard);
            Name = "LoadMoreCard";
            Size = new Size(200, 280);
            Click += OnCardClicked;
            ((System.ComponentModel.ISupportInitialize)bookCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingAnim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox bookCard;
        private PictureBox loadingAnim;
        private Label loadMoreText;
    }
}
