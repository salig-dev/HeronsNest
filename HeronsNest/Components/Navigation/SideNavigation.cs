using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components.Navigation
{
    public partial class SideNavigation : UserControl
    {
        Control NavBarReference;
        public SideNavigation()
        {
            InitializeComponent();
            NavBarReference = NavBarControl;
            Controls.Remove(NavBarControl);
        }

        private void OnMenuClick(object sender, EventArgs e)
        {
            int navBarControl = Controls.IndexOf(NavBarControl);

            if (navBarControl == -1)
            {
                Controls.Add(NavBarReference);
            } else
            {
                Controls.Remove(NavBarControl);
            }
        }
    }
}
