using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Client
{
    public partial class Form1 : Form
    {
        private User currentUser;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(User loggedInUser)
        {
            InitializeComponent();

            // Save logged in user
            currentUser = loggedInUser;

            // Show logged in user and role on dashboard
            lblLoggedInUser.Text = "Logged in as: " + currentUser.Username;
            lblRole.Text = "Role: " + currentUser.Role;

            // Apply simple role permissions
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            // Administrative Staff can see everything
            if (currentUser.Role == "Administrative Staff")
            {
                return;
            }

            // Patient only sees simple tabs
            if (currentUser.Role == "Patient")
            {
                mainTabs.TabPages.Remove(patientsTab);
                mainTabs.TabPages.Remove(inventoryTab);
                mainTabs.TabPages.Remove(analyticsTab);
                mainTabs.TabPages.Remove(monitoringTab);
            }

            // Doctor can see patients and monitoring, but not inventory or analytics
            if (currentUser.Role == "Doctor")
            {
                mainTabs.TabPages.Remove(inventoryTab);
                mainTabs.TabPages.Remove(analyticsTab);
            }

            // Nurse can see patients and monitoring, but not inventory or analytics
            if (currentUser.Role == "Nurse")
            {
                mainTabs.TabPages.Remove(inventoryTab);
                mainTabs.TabPages.Remove(analyticsTab);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close dashboard and return to login form
            this.Close();
        }
    }
}