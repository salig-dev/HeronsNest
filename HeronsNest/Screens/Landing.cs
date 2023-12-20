using HeronsNest.Screens;
using System.Diagnostics;

namespace HeronsNest
{
    public partial class Landing : Form
    {
        List<Control> screens = new List<Control>();

        private void InitializeScreens()
        {
            // By default, the VERY FIRST screen inserted here shall be the
            // default page.
            screens.Add(new Login(this));
        }

        public Landing()
        {
            InitializeComponent();
            InitializeScreens();

            if (screens.Count > 0)
            {
                // The very first item inserted in the list will
                // be the default screen.
                if (Controls.Count <= 0)
                {
                    SwitchView(screens[0]);
                }
            }
            else
            {
                throw new Exception(
                    "There are no screens initialized. " +
                    "Make sure that the screens array has screens initialized.");
            }
        }

        public void SwitchView(Control c)
        {
            // Since iisa lang rin naman naka-lagay na
            // screen edi clear nalang natin lahat
            Controls.Clear();

            // meaning neto, c will fill the whole 
            // form
            c.Dock = DockStyle.Fill;
            
            // then saka natin sha i-add don sa mismong form
            Controls.Add(c);
        }

        private void Landing_Load(object sender, EventArgs e)
        {

        }
    }
}