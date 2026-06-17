using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace HospitalManagement.Client
{
    public partial class Form1 : Form
    {
        private User currentUser;

        public Form1()
        {
            InitializeComponent();

            // Set up patient tab defaults
            SetupPatientTab();
        }

        public Form1(User loggedInUser)
        {
            InitializeComponent();

            // Set up patient tab defaults
            SetupPatientTab();

            // Save logged in user
            currentUser = loggedInUser;

            // Show logged in user and role on dashboard
            lblLoggedInUser.Text = "Logged in as: " + currentUser.Username;
            lblRole.Text = "Role: " + currentUser.Role;

            // Apply simple role permissions
            ApplyRolePermissions();
        }

        private void SetupPatientTab()
        {
            // Set grid selection behavior
            patientGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientGrid.MultiSelect = false;

            // Set default dropdown choices
            if (cmbPatientGender.Items.Count > 0 && cmbPatientGender.SelectedIndex == -1)
            {
                cmbPatientGender.SelectedIndex = 0;
            }

            if (cmbPatientDepartment.Items.Count > 0 && cmbPatientDepartment.SelectedIndex == -1)
            {
                cmbPatientDepartment.SelectedIndex = 0;
            }

            if (cmbPatientFilter.Items.Count > 0 && cmbPatientFilter.SelectedIndex == -1)
            {
                cmbPatientFilter.SelectedIndex = 0;
            }

            // Load patient records when dashboard opens
            LoadPatients();
        }

        private string GetSqlConnectionString()
        {
            // Get SQL Server connection string from App.config
            return ConfigurationManager.ConnectionStrings["HospitalSqlConnection"].ConnectionString;
        }

        private void LoadPatients()
        {
            // Clear old grid rows
            patientGrid.Rows.Clear();

            string sql =
                "SELECT PatientId, Name, Gender, DateOfBirth, Phone, Department, IsAdmitted, Notes " +
                "FROM Patients " +
                "ORDER BY PatientId";

            using (SqlConnection connection = new SqlConnection(GetSqlConnectionString()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string admittedText = Convert.ToBoolean(reader["IsAdmitted"]) ? "Admitted" : "Outpatient";

                            patientGrid.Rows.Add(
                                reader["PatientId"].ToString(),
                                reader["Name"].ToString(),
                                reader["Department"].ToString(),
                                admittedText,
                                "Not assigned"
                            );
                        }
                    }
                }
            }

            statusText.Text = "Patient records loaded.";
        }

        private void SearchPatients()
        {
            // Clear old grid rows
            patientGrid.Rows.Clear();

            string searchText = txtPatientSearch.Text.Trim();
            string filter = cmbPatientFilter.Text;

            string sql =
                "SELECT PatientId, Name, Gender, DateOfBirth, Phone, Department, IsAdmitted, Notes " +
                "FROM Patients " +
                "WHERE 1 = 1 ";

            if (searchText != "")
            {
                sql += "AND (PatientId LIKE @SearchText OR Name LIKE @SearchText) ";
            }

            if (filter == "Admitted")
            {
                sql += "AND IsAdmitted = 1 ";
            }
            else if (filter == "Outpatient")
            {
                sql += "AND IsAdmitted = 0 ";
            }
            else if (filter == "Critical Care")
            {
                sql += "AND Department = 'ICU' ";
            }
            else if (filter == "Discharged")
            {
                sql += "AND Notes LIKE '%discharged%' ";
            }

            sql += "ORDER BY PatientId";

            using (SqlConnection connection = new SqlConnection(GetSqlConnectionString()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (searchText != "")
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string admittedText = Convert.ToBoolean(reader["IsAdmitted"]) ? "Admitted" : "Outpatient";

                            patientGrid.Rows.Add(
                                reader["PatientId"].ToString(),
                                reader["Name"].ToString(),
                                reader["Department"].ToString(),
                                admittedText,
                                "Not assigned"
                            );
                        }
                    }
                }
            }

            statusText.Text = "Patient search completed.";
        }

        private void LoadPatientDetails(string patientId)
        {
            // Load full patient info into the textboxes
            string sql =
                "SELECT PatientId, Name, Gender, DateOfBirth, Phone, Department, IsAdmitted, Notes " +
                "FROM Patients " +
                "WHERE PatientId = @PatientId";

            using (SqlConnection connection = new SqlConnection(GetSqlConnectionString()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtPatientId.Text = reader["PatientId"].ToString();
                            txtPatientName.Text = reader["Name"].ToString();
                            cmbPatientGender.Text = reader["Gender"].ToString();
                            dtpPatientDob.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                            txtPatientPhone.Text = reader["Phone"].ToString();
                            cmbPatientDepartment.Text = reader["Department"].ToString();
                            chkPatientAdmitted.Checked = Convert.ToBoolean(reader["IsAdmitted"]);
                            txtPatientNotes.Text = reader["Notes"].ToString();
                        }
                    }
                }
            }
        }

        private void ClearPatientForm()
        {
            // Clear patient input fields
            txtPatientId.Clear();
            txtPatientName.Clear();
            txtPatientPhone.Clear();
            txtPatientNotes.Clear();
            chkPatientAdmitted.Checked = false;
            dtpPatientDob.Value = DateTime.Today;

            if (cmbPatientGender.Items.Count > 0)
            {
                cmbPatientGender.SelectedIndex = 0;
            }

            if (cmbPatientDepartment.Items.Count > 0)
            {
                cmbPatientDepartment.SelectedIndex = 0;
            }
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (txtPatientId.Text == "" || txtPatientName.Text == "")
            {
                MessageBox.Show("Patient ID and Patient Name are required.");
                return;
            }

            string sql =
                "INSERT INTO Patients " +
                "(PatientId, Name, Gender, DateOfBirth, Phone, Department, IsAdmitted, Notes) " +
                "VALUES " +
                "(@PatientId, @Name, @Gender, @DateOfBirth, @Phone, @Department, @IsAdmitted, @Notes)";

            try
            {
                using (SqlConnection connection = new SqlConnection(GetSqlConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", txtPatientId.Text);
                        command.Parameters.AddWithValue("@Name", txtPatientName.Text);
                        command.Parameters.AddWithValue("@Gender", cmbPatientGender.Text);
                        command.Parameters.AddWithValue("@DateOfBirth", dtpPatientDob.Value.Date);
                        command.Parameters.AddWithValue("@Phone", txtPatientPhone.Text);
                        command.Parameters.AddWithValue("@Department", cmbPatientDepartment.Text);
                        command.Parameters.AddWithValue("@IsAdmitted", chkPatientAdmitted.Checked);
                        command.Parameters.AddWithValue("@Notes", txtPatientNotes.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Patient added successfully.");
                ClearPatientForm();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (txtPatientId.Text == "" || txtPatientName.Text == "")
            {
                MessageBox.Show("Patient ID and Patient Name are required.");
                return;
            }

            string sql =
                "UPDATE Patients SET " +
                "Name = @Name, " +
                "Gender = @Gender, " +
                "DateOfBirth = @DateOfBirth, " +
                "Phone = @Phone, " +
                "Department = @Department, " +
                "IsAdmitted = @IsAdmitted, " +
                "Notes = @Notes " +
                "WHERE PatientId = @PatientId";

            try
            {
                using (SqlConnection connection = new SqlConnection(GetSqlConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", txtPatientId.Text);
                        command.Parameters.AddWithValue("@Name", txtPatientName.Text);
                        command.Parameters.AddWithValue("@Gender", cmbPatientGender.Text);
                        command.Parameters.AddWithValue("@DateOfBirth", dtpPatientDob.Value.Date);
                        command.Parameters.AddWithValue("@Phone", txtPatientPhone.Text);
                        command.Parameters.AddWithValue("@Department", cmbPatientDepartment.Text);
                        command.Parameters.AddWithValue("@IsAdmitted", chkPatientAdmitted.Checked);
                        command.Parameters.AddWithValue("@Notes", txtPatientNotes.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No patient found with that ID.");
                            return;
                        }
                    }
                }

                MessageBox.Show("Patient updated successfully.");
                ClearPatientForm();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message);
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            // Validate patient ID
            if (txtPatientId.Text == "")
            {
                MessageBox.Show("Enter or select a Patient ID first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM Patients WHERE PatientId = @PatientId";

            try
            {
                using (SqlConnection connection = new SqlConnection(GetSqlConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", txtPatientId.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No patient found with that ID.");
                            return;
                        }
                    }
                }

                MessageBox.Show("Patient deleted successfully.");
                ClearPatientForm();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message);
            }
        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {
            // Clear patient input fields
            ClearPatientForm();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            // Search patient records
            SearchPatients();
        }

        private void btnPatientRefresh_Click(object sender, EventArgs e)
        {
            // Reload all patient records
            txtPatientSearch.Clear();

            if (cmbPatientFilter.Items.Count > 0)
            {
                cmbPatientFilter.SelectedIndex = 0;
            }

            LoadPatients();
        }

        private void patientGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row
            if (e.RowIndex < 0)
            {
                return;
            }

            string patientId = patientGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Load selected patient into form fields
            LoadPatientDetails(patientId);
        }
    }
}