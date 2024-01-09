using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

    }
}
