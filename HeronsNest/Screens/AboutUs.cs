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
    public partial class AboutUs : UserControl
    {
        Landing MainForm;
        public AboutUs(Landing mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            backBtn.Click += backBtn_Click;
        }


        private void backBtn_Click(object sender, EventArgs e) => MainForm.SwitchView(new Home(MainForm));

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
