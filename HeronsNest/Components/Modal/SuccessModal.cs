

namespace HeronsNest.Components.Modal
{
    public partial class SuccessModal : UserControl
    {
        private Landing mainForm;
        public SuccessModal(Landing mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void OnModalClose(object sender, EventArgs e)
        {
            mainForm.RemovePopup(this);
        }
    }
}
