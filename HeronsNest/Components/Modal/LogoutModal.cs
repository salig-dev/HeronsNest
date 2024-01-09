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
    public partial class LogoutWindow : UserControl
    {
        Landing MainForm;
        public LogoutWindow(Landing mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
        }

        private void logout_No_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }

        private void logout_Yes_Click(object sender, EventArgs e)
        {
            MainForm.SwitchView(new Screens.Login(MainForm));
        }
    }
}
