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
            leftNavBar1.MainForm = mainForm;
        }
    }
}
