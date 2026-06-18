using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Configuration;

namespace HospitalManagement.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

            // Connect to MongoDB
            // Connect to MongoDB using App.config
            string mongoConnectionString =
                ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString;

            MongoClient client = new MongoClient(mongoConnectionString);

            IMongoDatabase database =
                client.GetDatabase(MongoUrl.Create(mongoConnectionString).DatabaseName);

            IMongoCollection<User> users = database.GetCollection<User>("Users");

            // Find matching user
            User loggedInUser = users
                .Find(u => u.Username == username && u.Password == password)
                .FirstOrDefault();

            // Check login result
            if (loggedInUser == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            MessageBox.Show("Login successful. Role: " + loggedInUser.Role);

            // Open main dashboard
            Form1 dashboard = new Form1(loggedInUser);

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
            registerForm.ShowDialog();

            // Show login form again after register form closes
            this.Show();
        }
    }
}