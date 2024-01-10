using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeronsNest.Components
{

    public partial class IconButton : UserControl
    {
        public Image image;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return buttonTitle.Text; }
            set { buttonTitle.Text = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                iconHolder.Image = image;
            }
        }

        private EventHandler IconButtonClicked;

        public event EventHandler OnIconButtonClicked
        {
            add => IconButtonClicked += value;
            remove => IconButtonClicked = null!;
        }

        public IconButton()
        {
            InitializeComponent();
        }

        private void IconButtonClick(object sender, EventArgs e)
        {
            IconButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
