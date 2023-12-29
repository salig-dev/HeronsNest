using HeronsNest.Models;
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
    public partial class Comp_Searchbar : UserControl
    {
        public Comp_Searchbar()
        {
            InitializeComponent();
            timeText.Text = "....";
            dateText.Text = "-- - -- - --";
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comp_Searchbar_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);
                    DateTime currentTime = DateTime.Now;
                    Invoke((MethodInvoker)delegate
                    {
                        timeText.Text = $"{(currentTime.Hour <= 9 ? "0" + currentTime.Hour : currentTime.Hour)}:" +
                        $"{(currentTime.Minute <= 9 ? "0" + currentTime.Minute : currentTime.Minute)}:" +
                        $"{(currentTime.Second <= 9 ? "0" + currentTime.Second : currentTime.Second)}";
                        dateText.Text = $"{(currentTime.Day <= 9 ? "0" + currentTime.Day : currentTime.Day)} - {(currentTime.Month <= 9 ? "0" + currentTime.Month : currentTime.Month)} - {(currentTime.Year <= 9 ? "0" + currentTime.Year : currentTime.Year)}";
                    });
                }
            });
        }
    }
}
