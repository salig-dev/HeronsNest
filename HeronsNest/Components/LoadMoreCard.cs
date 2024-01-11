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
    public partial class LoadMoreCard : UserControl
    {
        public EventHandler onCardClicked;
        public event EventHandler OnCardClick
        {
            add => onCardClicked += value;
            remove => onCardClicked -= value;
        }
        public LoadMoreCard()
        {
            InitializeComponent();
        }

        private void OnCardClicked(object sender, EventArgs e)
        {
            onCardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void bookCard_Click(object sender, EventArgs e)
        {
            onCardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void loadingAnim_Click(object sender, EventArgs e)
        {
            onCardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void loadMoreText_Click(object sender, EventArgs e)
        {
            onCardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
