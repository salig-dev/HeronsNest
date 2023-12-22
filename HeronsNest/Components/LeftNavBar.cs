using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components
{
    public partial class LeftNavBar : UserControl
    {
        public LeftNavBar()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton5_Load(object sender, EventArgs e)
        {

        }

        private void OnNavClose(object sender, EventArgs e)
        {
            Controls.Remove(this);
            Dispose();
        }
    }
}
