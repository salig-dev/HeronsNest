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
    public partial class BookPreview : UserControl
    {
        Landing mainForm;
        public BookPreview(Landing mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }
    }
}
