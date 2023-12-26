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
            // leftNavBar1.MainForm = mainForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void bookRating_Click(object sender, EventArgs e)
        {

        }

        private void statusText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void bookDetails_Click(object sender, EventArgs e)
        {

        }

        private void BookPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
