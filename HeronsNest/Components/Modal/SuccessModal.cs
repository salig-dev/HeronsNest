

namespace HeronsNest.Components.Modal
{
    public partial class SuccessModal : UserControl
    {
        private Landing mainForm;
        private Control? NextScreen;
        private string? Description;
        public SuccessModal(Landing mainForm , Control? nextScreen, string? description)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            NextScreen = nextScreen;
            Description = description;

            successDesc.Text = description;
        }

        private void OnModalClose(object sender, EventArgs e)
        {
            mainForm.RemovePopup();

            if (NextScreen != null) mainForm.SwitchView(NextScreen);
        }
    }
}
