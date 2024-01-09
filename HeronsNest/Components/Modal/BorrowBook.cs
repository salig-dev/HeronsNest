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
    public partial class BorrowBook : UserControl
    {
        Landing MainForm;
        public BorrowBook(Landing mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
        }

        private void OnModalExit(object sender, EventArgs e)
        {
            MainForm.RemovePopup(this);
        }
    }
}
