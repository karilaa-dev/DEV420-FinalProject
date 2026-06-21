using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagement.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Icon = SystemIcons.Shield;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // Get form input
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            // Basic validation
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            User loggedInUser;

            try
            {
                loggedInUser = UserRepository.FindByUsername(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to MongoDB.\n\n" + ex.Message);
                return;
            }

            if (loggedInUser == null || !UserRepository.IsPasswordValid(loggedInUser, password))
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            try
            {
                SqlUserProfileSync.SyncUserProfile(loggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login succeeded, but the SQL profile could not be synchronized. Check the SQL setup script.\n\n" +
                    ex.Message
                );
                return;
            }

            // Open main dashboard
            Main dashboard = new Main(loggedInUser);

            // Hide login screen while dashboard is open
            this.Hide();

            // Show dashboard and wait until it closes
            dashboard.ShowDialog();

            // Show login screen again after logout
            this.Show();

            // Clear password after logout
            textBox_password.Clear();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            // Hide login form while register form is open
            this.Hide();

            // Open register form
            RegisterForm registerForm = new RegisterForm();
            DialogResult registerResult = registerForm.ShowDialog();

            // Show login form again after register form closes
            this.Show();

            if (registerResult == DialogResult.OK && registerForm.RegisteredUsername != "")
            {
                textBox_username.Text = registerForm.RegisteredUsername;
                textBox_password.Clear();
                textBox_password.Focus();
            }
        }
    }
}
