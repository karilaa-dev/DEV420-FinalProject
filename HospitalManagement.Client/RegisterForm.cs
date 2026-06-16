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

namespace HospitalManagement.Client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            // Fill role dropdown for authorization level
            comboBox_role.Items.Clear();
            comboBox_role.Items.Add("Doctor");
            comboBox_role.Items.Add("Nurse");
            comboBox_role.Items.Add("Administrative Staff");
            comboBox_role.Items.Add("Patient");
            comboBox_role.SelectedIndex = 0;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            // Get form input
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string role = comboBox_role.Text;

            // Basic validation
            if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Connect to MongoDB
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("HospitalManagementDB");
            IMongoCollection<User> users = database.GetCollection<User>("Users");

            // Check if username already exists
            User existingUser = users.Find(u => u.Username == username).FirstOrDefault();

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
                Password = password,
                Role = role
            };

            // Save user to MongoDB
            users.InsertOne(newUser);

            MessageBox.Show("Registration successful.");

            // Clear form
            textBox_username.Clear();
            textBox_password.Clear();
            comboBox_role.SelectedIndex = 0;
        }

        private void button_backToLogin_Click(object sender, EventArgs e)
        {
            // Close register form and return to login form
            this.Close();
        }
    }
}