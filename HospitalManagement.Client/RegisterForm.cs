using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagement.Client
{
    public partial class RegisterForm : Form
    {
        public string RegisteredUsername { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
            Icon = SystemIcons.Application;
            ConfigureRoleChoices();
            RegisteredUsername = "";
        }

        private void ConfigureRoleChoices()
        {
            comboBox_role.Items.Clear();
            comboBox_role.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_role.Items.Add(HospitalRoles.Doctor);
            comboBox_role.Items.Add(HospitalRoles.Nurse);
            comboBox_role.Items.Add(HospitalRoles.AdministrativeStaff);
            comboBox_role.Items.Add(HospitalRoles.Patient);

            comboBox_role.SelectedIndex = 0;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            // Get form input
            string username = textBox_username.Text.Trim();
            string displayName = textBox_displayName.Text.Trim();
            string password = textBox_password.Text;
            string role = comboBox_role.Text;

            // Basic validation
            if (username == "" || displayName == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User existingUser;

            try
            {
                existingUser = UserRepository.FindByUsername(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to MongoDB.\n\n" + ex.Message);
                return;
            }

            if (existingUser != null)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            // Create new user
            User newUser = new User
            {
                UserId = Guid.NewGuid().ToString(),
                Username = username,
                DisplayName = displayName,
                Password = password,
                Role = role
            };

            try
            {
                UserRepository.Insert(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("User could not be saved to MongoDB.\n\n" + ex.Message);
                return;
            }

            try
            {
                SqlUserProfileSync.SyncUserProfile(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration succeeded, but the matching SQL profile could not be created. Run the updated SQL setup/reset script before using this account.\n\n" +
                    ex.Message
                );
                return;
            }

            MessageBox.Show("Registration successful.");
            RegisteredUsername = username;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_backToLogin_Click(object sender, EventArgs e)
        {
            // Close register form and return to login form
            this.Close();
        }
    }
}
