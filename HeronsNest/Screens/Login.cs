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
    public partial class Login : UserControl
    {
        // Reason why we pass the main form is because
        // need rin natin ng access sa SwitchView (naka-public siya).
        // Very important rin siya so that we can have full control
        // ng main form functions.
        public Login(Landing mainForm)
        {
            InitializeComponent();
        }
    }
}
