namespace HeronsNest.Screens
{
    partial class Balance
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
            leftNavBar = new Components.LeftNavBar();
            balanceTitle = new Label();
            titleText = new Label();
            statusText = new Label();
            penaltyText = new Label();
            totalText = new Label();
            comp_DateTime1 = new Components.Comp_DateTime();
            backBtn = new Label();
            backIcon = new PictureBox();
            balanceListView = new Components.List.CustomListView();
            ((System.ComponentModel.ISupportInitialize)backIcon).BeginInit();
            SuspendLayout();
            // 
            // leftNavBar
            // 
            leftNavBar.AutoSize = true;
            leftNavBar.BackColor = Color.White;
            leftNavBar.Location = new Point(0, 0);
            leftNavBar.MainForm = null;
            leftNavBar.Name = "leftNavBar";
            leftNavBar.Size = new Size(206, 648);
            leftNavBar.TabIndex = 0;
            // 
            // balanceTitle
            // 
            balanceTitle.AutoSize = true;
            balanceTitle.Font = new Font("PP Hatton", 20F);
            balanceTitle.ForeColor = Color.FromArgb(0, 149, 168);
            balanceTitle.Location = new Point(231, 73);
            balanceTitle.Name = "balanceTitle";
            balanceTitle.Size = new Size(284, 32);
            balanceTitle.TabIndex = 1;
            balanceTitle.Text = "Pending Payments";
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("PP Hatton", 12F);
            titleText.ForeColor = Color.FromArgb(76, 76, 76);
            titleText.Location = new Point(412, 131);
            titleText.Name = "titleText";
            titleText.Size = new Size(49, 19);
            titleText.TabIndex = 7;
            titleText.Text = "Title";
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Font = new Font("PP Hatton", 12F);
            statusText.ForeColor = Color.FromArgb(76, 76, 76);
            statusText.Location = new Point(553, 131);
            statusText.Name = "statusText";
            statusText.Size = new Size(66, 19);
            statusText.TabIndex = 10;
            statusText.Text = "Status";
            // 
            // penaltyText
            // 
            penaltyText.AutoSize = true;
            penaltyText.Font = new Font("PP Hatton", 12F);
            penaltyText.ForeColor = Color.FromArgb(76, 76, 76);
            penaltyText.Location = new Point(651, 131);
            penaltyText.Name = "penaltyText";
            penaltyText.Size = new Size(74, 19);
            penaltyText.TabIndex = 12;
            penaltyText.Text = "Penalty";
            // 
            // totalText
            // 
            totalText.AutoSize = true;
            totalText.Font = new Font("PP Hatton", 12F);
            totalText.ForeColor = Color.FromArgb(76, 76, 76);
            totalText.Location = new Point(747, 214);
            totalText.Name = "totalText";
            totalText.Size = new Size(53, 19);
            totalText.TabIndex = 14;
            totalText.Text = "Total";
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(598, 22);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 44);
            comp_DateTime1.TabIndex = 21;
            // 
            // backBtn
            // 
            backBtn.AutoSize = true;
            backBtn.Font = new Font("PP Hatton", 9F);
            backBtn.ForeColor = Color.FromArgb(76, 76, 76);
            backBtn.Location = new Point(251, 43);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(116, 14);
            backBtn.TabIndex = 28;
            backBtn.Text = "Back to Library";
            backBtn.Click += backBtn_Click;
            // 
            // backIcon
            // 
            backIcon.Image = Properties.Resources.back;
            backIcon.Location = new Point(231, 43);
            backIcon.Name = "backIcon";
            backIcon.Size = new Size(14, 14);
            backIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            backIcon.TabIndex = 29;
            backIcon.TabStop = false;
            backIcon.Click += backIcon_Click;
            // 
            // balanceListView
            // 
            balanceListView.DataSource = null;
            balanceListView.Location = new Point(231, 157);
            balanceListView.Name = "balanceListView";
            balanceListView.Size = new Size(711, 360);
            balanceListView.TabIndex = 30;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(balanceListView);
            Controls.Add(backIcon);
            Controls.Add(backBtn);
            Controls.Add(totalText);
            Controls.Add(penaltyText);
            Controls.Add(statusText);
            Controls.Add(titleText);
            Controls.Add(balanceTitle);
            Controls.Add(leftNavBar);
            Controls.Add(comp_DateTime1);
            Name = "Balance";
            Size = new Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)backIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.LeftNavBar leftNavBar;
        private Label balanceTitle;
        private Label titleText;
        private Label statusText;
        private Label penaltyText;
        private Label totalText;
        private Components.Comp_DateTime comp_DateTime1;
        private Button btn_Return;
        private Label backBtn;
        private PictureBox backIcon;
        private Components.List.CustomListView balanceListView;
    }
}
