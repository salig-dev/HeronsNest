using HeronsNest.Components;
using HeronsNest.Models;
using HeronsNest.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Screens
{
    public partial class Balance : UserControl
    {
        Landing mainForm;
        public Balance(Landing mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            leftNavBar.MainForm = mainForm;

            var overdueUserBorrows = mainForm.BorrowBook.GetAllBorrows(UserSession.Instance.User).Result.Where(
                x =>
                {
                    DateTime dateBorrowed = DateTime.ParseExact(x.DateBorrowed!, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    DateTime dateDue = DateTime.ParseExact(x.DateDue!, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    TimeSpan span = dateDue - dateBorrowed;
                    return span.Days > 3;
                }
                );

            foreach (BookBorrow data in overdueUserBorrows)
            {
                balanceListView.Controls.Add(new BalanceBookCard(mainForm, data));
            }
        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void backIcon_Click_1(object sender, EventArgs e)
        {

        }

        private void totalText_Click(object sender, EventArgs e)
        {

        }
    }
}
