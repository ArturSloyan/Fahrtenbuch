using FahrtenbuchProjektCore.Context;
using FahrtenbuchProjektCore.DataAccessLayer;

namespace FahrtenbuchProjekt
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var context = new JourneybookContext();
            var loginAccessLayer = new LoginAccessLayer(context);

            if (loginAccessLayer.Login(textBoxEmail.Text, textBoxPassword.Text))
            {
                new MainWindow(loginAccessLayer.GetLoggedInEmployee(textBoxEmail.Text)).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Username or password is invalid!");
                textBoxEmail.Clear();
                textBoxPassword.Clear();
                textBoxEmail.Focus();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
