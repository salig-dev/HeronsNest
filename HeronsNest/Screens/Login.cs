using HeronsNest.Algorithms.Authentication;
using HeronsNest.Components.Modal;
using HeronsNest.Context;

namespace HeronsNest.Screens
{
    public partial class Login : UserControl
    {
        Landing mainForm;

        // Reason why we pass the main form is because
        // need rin natin ng access sa SwitchView (naka-public siya).
        // Very important rin siya so that we can have full control
        // ng main form functions.
        public Login(Landing mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.ShowPopup(new SuccessModal(mainForm));
        }

        private void OnUserLogin(object sender, EventArgs e)
        {
            var Result = mainForm.Authenticator!.LoginUser(new Models.DTO.UserDTO()
            {
                Id = usernameTextBox.Text,
                Password = passwordTextBox.Text,
            });

            tipTextLabel.Text = "Loading...";

            switch (Result)
            {
                case Enums.AuthResult.Success:
                    mainForm.ShowPopup(new SuccessModal(mainForm));
                    mainForm.SwitchView(new Home(mainForm));
                    break;
                case Enums.AuthResult.Failed:
                    tipTextLabel.Text = "Invalid Credentials!";
                    break;
                case Enums.AuthResult.NotFound:
                    tipTextLabel.Text = "Account not found!";
                    break;
            }


            // popup testing
            //mainForm.ShowPopup(new SuccessModal(mainForm));
        }
    }
}
