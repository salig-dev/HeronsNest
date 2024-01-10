using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components.Modal
{
    public partial class ReserveBorrowDateCheckModal : UserControl
    {
        Landing MainForm;
        string BookIsbn;
        public ReserveBorrowDateCheckModal(Landing mainForm, string bookIsbn)
        {
            InitializeComponent();

            MainForm = mainForm;
            BookIsbn = bookIsbn;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var allBorrows = MainForm.BorrowBook.GetAllBorrows(null, bookIsbn: BookIsbn).Result;
            var allReserves = MainForm.ReserveBook.GetAllReservations(null, bookIsbn: BookIsbn).Result;

            foreach (var borrow in allBorrows)
            {
                Label l = new();
                DateTime dateBorrowed = DateTime.Parse(borrow.DateBorrowed);
                DateTime dateDue = DateTime.Parse(borrow.DateDue);

                l.BackColor = dateBorrowed >= dateDue ? Color.Red : Color.LightGreen;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Text = $"{borrow.DateBorrowed} - {borrow.DateDue} {((dateBorrowed >= dateDue) ? "(DUE)" : "")}";
                l.AutoSize = true;

                borrowedDatesList.Controls.Add(l);
            }

            foreach (var reservation in allReserves)
            {
                Label l = new();
                DateTime dateBorrowed = DateTime.Parse(reservation.DateReserved);

                l.Text = $"{dateBorrowed}";

                reservedDatesList.Controls.Add(l);
            }
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }
    }
}
