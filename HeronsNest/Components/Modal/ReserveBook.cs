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
    public partial class ReserveBook : UserControl
    {
        Landing MainForm;
        public ReserveBook(Landing mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
        }

        private void ReserveBook_Load(object sender, EventArgs e)
        {

        }

        private void toReserve_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }
    }
}
