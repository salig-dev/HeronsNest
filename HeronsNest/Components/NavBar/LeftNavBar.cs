using HeronsNest.Screens;
using System.Diagnostics;

namespace HeronsNest.Components
{
    public partial class LeftNavBar : UserControl
    {

        public Landing MainForm { get; set; }
        public LeftNavBar()
        {
            InitializeComponent();

            /**
             * Task.Run(async () =>
            {
                while (true)
                {
                    long memoryBefore = GC.GetTotalMemory(true);
                    await Task.Delay(1000);
                    GC.Collect();
                    long memoryAfter = GC.GetTotalMemory(true);
                    long memoryUsed = memoryAfter - memoryBefore;
                    long maxMemory = Process.GetCurrentProcess().MaxWorkingSet;
                    double memoryPercentage = (double)memoryUsed / maxMemory * 100;

                    Invoke(delegate ()
                    {
                        memPercentageLbl.Text = $"{memoryPercentage}%";
                        memoryOutOf.Text = $"{memoryUsed}/{maxMemory}";
                    });
                }
            });
             */
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

        private void OnNavClose(object sender, EventArgs e)
        {
            Controls.Remove(this);
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeClicked(object sender, EventArgs e)
        {
            MainForm?.SwitchView(new Screens.Home(MainForm));
        }

        private void SearchClicked(object sender, EventArgs e)
        {
            MainForm?.SwitchView(new Search(MainForm));
        }

        private void MyShelfClicked(object sender, EventArgs e)
        {
            MainForm?.SwitchView(new MyShelf(MainForm));

        }

        private void BalanceClicked(object sender, EventArgs e)
        {
            MainForm?.SwitchView(new Balance(MainForm));
        }

        private void iconButton8_Load(object sender, EventArgs e)
        {
            MainForm?.ShowPopup(new Modal.LogoutWindow(MainForm));
        }
    }
}
