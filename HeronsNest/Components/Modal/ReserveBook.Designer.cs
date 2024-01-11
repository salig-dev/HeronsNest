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
            reserveDate = new DateTimePicker();
            reservedDatesList = new List.CustomListView();
            unavailableReservedDatesLbl = new Label();
            label1 = new Label();
            backBtn = new PictureBox();
            errorTextLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // reserveDetails
            // 
            reserveDetails.Font = new Font("PP Hatton", 12F);
            reserveDetails.ForeColor = Color.FromArgb(0, 149, 168);
            reserveDetails.Location = new Point(23, 53);
            reserveDetails.Name = "reserveDetails";
            reserveDetails.Size = new Size(313, 19);
            reserveDetails.TabIndex = 1;
            reserveDetails.Text = "Fill Up Details";
            reserveDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookReserve
            // 
            bookReserve.BackColor = Color.FromArgb(0, 149, 168);
            bookReserve.FlatAppearance.BorderSize = 0;
            bookReserve.FlatStyle = FlatStyle.Flat;
            bookReserve.Font = new Font("PP Hatton", 10F);
            bookReserve.ForeColor = Color.White;
            bookReserve.Location = new Point(111, 330);
            bookReserve.Name = "bookReserve";
            bookReserve.Size = new Size(136, 34);
            bookReserve.TabIndex = 0;
            bookReserve.Text = "RESERVE";
            bookReserve.UseVisualStyleBackColor = false;
            bookReserve.Click += OnReserve;
            // 
            // reserveDate
            // 
            reserveDate.Font = new Font("Nourd-Regular", 10F);
            reserveDate.Location = new Point(23, 290);
            reserveDate.MinDate = new DateTime(2024, 1, 10, 0, 0, 0, 0);
            reserveDate.Name = "reserveDate";
            reserveDate.Size = new Size(313, 23);
            reserveDate.TabIndex = 8;
            // 
            // reservedDatesList
            // 
            reservedDatesList.DataSource = null;
            reservedDatesList.Font = new Font("Nourd-Regular", 9F);
            reservedDatesList.Location = new Point(23, 108);
            reservedDatesList.Name = "reservedDatesList";
            reservedDatesList.Size = new Size(313, 151);
            reservedDatesList.TabIndex = 28;
            // 
            // unavailableReservedDatesLbl
            // 
            unavailableReservedDatesLbl.AutoSize = true;
            unavailableReservedDatesLbl.Font = new Font("PP Hatton", 10F);
            unavailableReservedDatesLbl.ForeColor = Color.FromArgb(76, 76, 76);
            unavailableReservedDatesLbl.Location = new Point(23, 88);
            unavailableReservedDatesLbl.Name = "unavailableReservedDatesLbl";
            unavailableReservedDatesLbl.Size = new Size(227, 17);
            unavailableReservedDatesLbl.TabIndex = 29;
            unavailableReservedDatesLbl.Text = "Unavailable Reserved Dates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PP Hatton", 9F);
            label1.ForeColor = Color.FromArgb(76, 76, 76);
            label1.Location = new Point(23, 273);
            label1.Name = "label1";
            label1.Size = new Size(126, 14);
            label1.TabIndex = 30;
            label1.Text = "Reservation Date";
            // 
            // backBtn
            // 
            backBtn.Image = Properties.Resources.back;
            backBtn.Location = new Point(23, 53);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(14, 14);
            backBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            backBtn.TabIndex = 32;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // errorTextLabel
            // 
            errorTextLabel.AutoSize = true;
            errorTextLabel.Font = new Font("PP Hatton", 8F);
            errorTextLabel.ForeColor = Color.FromArgb(76, 76, 76);
            errorTextLabel.Location = new Point(91, 378);
            errorTextLabel.Name = "errorTextLabel";
            errorTextLabel.Size = new Size(0, 13);
            errorTextLabel.TabIndex = 33;
            // 
            // ReserveBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(errorTextLabel);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(unavailableReservedDatesLbl);
            Controls.Add(reservedDatesList);
            Controls.Add(reserveDate);
            Controls.Add(reserveDetails);
            Controls.Add(bookReserve);
            Name = "ReserveBook";
            Size = new Size(360, 420);
            Load += ReserveBook_Load;
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label reserveDetails;
        private Label toReserve;
        private Button bookReserve;
        private DateTimePicker reserveDate;
        private DateTimePicker dateTimePicker2;
        private Button btnReturn;
        private List.CustomListView reservedDatesList;
        private Label unavailableReservedDatesLbl;
        private Label label1;
        private PictureBox backBtn;
        private Label errorTextLabel;
    }
}
