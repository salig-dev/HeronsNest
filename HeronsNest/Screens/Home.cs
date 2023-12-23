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
    public partial class Home : UserControl
    {
        Landing mainForm;

        public Home(Landing mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Login(mainForm));
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new MyShelf(mainForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new BookPreview(mainForm));
        }
    }
}
