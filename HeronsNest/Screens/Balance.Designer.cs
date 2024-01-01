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
            leftNavBar1 = new Components.LeftNavBar();
            label1 = new Label();
            balanceBookCard1 = new Components.BalanceBookCard();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            balanceBookCard2 = new Components.BalanceBookCard();
            comp_DateTime1 = new Components.Comp_DateTime();
            comp_Searchbar2 = new Components.Comp_Searchbar();
            SuspendLayout();
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(200, 600);
            leftNavBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PP Hatton", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 149, 168);
            label1.Location = new Point(231, 156);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 1;
            label1.Text = "Pending Payments";
            // 
            // balanceBookCard1
            // 
            balanceBookCard1.Location = new Point(276, 244);
            balanceBookCard1.Name = "balanceBookCard1";
            balanceBookCard1.Size = new Size(658, 150);
            balanceBookCard1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PP Hatton", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(76, 76, 76);
            label2.Location = new Point(412, 214);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 7;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PP Hatton", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(76, 76, 76);
            label3.Location = new Point(553, 214);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 10;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PP Hatton", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(76, 76, 76);
            label4.Location = new Point(651, 214);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 12;
            label4.Text = "Penalty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PP Hatton", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(76, 76, 76);
            label5.Location = new Point(747, 214);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 14;
            label5.Text = "Total";
            // 
            // balanceBookCard2
            // 
            balanceBookCard2.Location = new Point(276, 400);
            balanceBookCard2.Name = "balanceBookCard2";
            balanceBookCard2.Size = new Size(658, 150);
            balanceBookCard2.TabIndex = 15;
            // 
            // comp_DateTime1
            // 
            comp_DateTime1.Location = new Point(598, 22);
            comp_DateTime1.Name = "comp_DateTime1";
            comp_DateTime1.Size = new Size(249, 44);
            comp_DateTime1.TabIndex = 21;
            // 
            // comp_Searchbar2
            // 
            comp_Searchbar2.Location = new Point(225, 28);
            comp_Searchbar2.Margin = new Padding(3, 2, 3, 2);
            comp_Searchbar2.Name = "comp_Searchbar2";
            comp_Searchbar2.Size = new Size(387, 35);
            comp_Searchbar2.TabIndex = 22;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(comp_Searchbar2);
            Controls.Add(balanceBookCard2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(balanceBookCard1);
            Controls.Add(label1);
            Controls.Add(leftNavBar1);
            Controls.Add(comp_DateTime1);
            Name = "Balance";
            Size = new Size(1000, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.LeftNavBar leftNavBar1;
        private Label label1;
        private Components.BalanceBookCard balanceBookCard1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Components.BalanceBookCard balanceBookCard2;
        private Components.Comp_DateTime comp_DateTime1;
        private Components.Comp_Searchbar comp_Searchbar2;
    }
}
