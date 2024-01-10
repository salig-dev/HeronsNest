namespace HeronsNest.Components.Modal
{
    partial class ReserveBorrowDateCheckModal
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
            borrowedDatesList = new List.CustomListView();
            label2 = new Label();
            reservedDatesList = new List.CustomListView();
            reserveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Borrowed Dates";
            // 
            // borrowedDatesList
            // 
            borrowedDatesList.AutoScroll = true;
            borrowedDatesList.DataSource = null;
            borrowedDatesList.Location = new Point(20, 49);
            borrowedDatesList.Name = "borrowedDatesList";
            borrowedDatesList.Size = new Size(318, 134);
            borrowedDatesList.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(10, 192);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 2;
            label2.Text = "Reserved Dates";
            // 
            // reservedDatesList
            // 
            reservedDatesList.DataSource = null;
            reservedDatesList.Location = new Point(20, 231);
            reservedDatesList.Name = "reservedDatesList";
            reservedDatesList.Size = new Size(318, 133);
            reservedDatesList.TabIndex = 2;
            // 
            // reserveBtn
            // 
            reserveBtn.BackColor = Color.FromArgb(82, 167, 133);
            reserveBtn.FlatAppearance.BorderSize = 0;
            reserveBtn.FlatStyle = FlatStyle.Flat;
            reserveBtn.Font = new Font("Microsoft Sans Serif", 9F);
            reserveBtn.ForeColor = Color.White;
            reserveBtn.Location = new Point(126, 378);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(110, 30);
            reserveBtn.TabIndex = 11;
            reserveBtn.Text = "OK";
            reserveBtn.UseVisualStyleBackColor = false;
            reserveBtn.Click += OnOkButtonClick;
            // 
            // ReserveBorrowDateCheckModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(reserveBtn);
            Controls.Add(reservedDatesList);
            Controls.Add(label2);
            Controls.Add(borrowedDatesList);
            Controls.Add(label1);
            Name = "ReserveBorrowDateCheckModal";
            Size = new Size(360, 420);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private List.CustomListView borrowedDatesList;
        private Label label2;
        private List.CustomListView reservedDatesList;
        private Button reserveBtn;
    }
}
