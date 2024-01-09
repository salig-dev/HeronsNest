namespace HeronsNest.Components.Modal
{
    partial class ReserveBook
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
            reserveDetails = new Label();
            bookReserve = new Button();
            toRerserve = new DateTimePicker();
            btnReturn = new Button();
            customListView1 = new List.CustomListView();
            unavailableReservedDatesLbl = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // reserveDetails
            // 
            reserveDetails.AutoSize = true;
            reserveDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reserveDetails.Location = new Point(130, 28);
            reserveDetails.Name = "reserveDetails";
            reserveDetails.Size = new Size(116, 21);
            reserveDetails.TabIndex = 1;
            reserveDetails.Text = "Fill Up Details";
            // 
            // bookReserve
            // 
            bookReserve.BackColor = Color.FromArgb(128, 255, 128);
            bookReserve.FlatStyle = FlatStyle.Flat;
            bookReserve.Location = new Point(220, 371);
            bookReserve.Name = "bookReserve";
            bookReserve.Size = new Size(122, 34);
            bookReserve.TabIndex = 0;
            bookReserve.Text = "Reserve";
            bookReserve.UseVisualStyleBackColor = false;
            // 
            // toRerserve
            // 
            toRerserve.Location = new Point(24, 342);
            toRerserve.Name = "toRerserve";
            toRerserve.Size = new Size(313, 23);
            toRerserve.TabIndex = 8;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(29, 17);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(47, 40);
            btnReturn.TabIndex = 27;
            btnReturn.Text = "<-";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // customListView1
            // 
            customListView1.DataSource = null;
            customListView1.Location = new Point(24, 107);
            customListView1.Name = "customListView1";
            customListView1.Size = new Size(313, 187);
            customListView1.TabIndex = 28;
            // 
            // unavailableReservedDatesLbl
            // 
            unavailableReservedDatesLbl.AutoSize = true;
            unavailableReservedDatesLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unavailableReservedDatesLbl.Location = new Point(24, 77);
            unavailableReservedDatesLbl.Name = "unavailableReservedDatesLbl";
            unavailableReservedDatesLbl.Size = new Size(223, 21);
            unavailableReservedDatesLbl.TabIndex = 29;
            unavailableReservedDatesLbl.Text = "Unavailable Reserved Dates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 312);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 30;
            label1.Text = "Reservation Date";
            // 
            // ReserveBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(unavailableReservedDatesLbl);
            Controls.Add(customListView1);
            Controls.Add(btnReturn);
            Controls.Add(toRerserve);
            Controls.Add(reserveDetails);
            Controls.Add(bookReserve);
            Name = "ReserveBook";
            Size = new Size(360, 420);
            Load += ReserveBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label reserveDetails;
        private Label toReserve;
        private Button bookReserve;
        private DateTimePicker toRerserve;
        private DateTimePicker dateTimePicker2;
        private Button btnReturn;
        private List.CustomListView customListView1;
        private Label unavailableReservedDatesLbl;
        private Label label1;
    }
}
