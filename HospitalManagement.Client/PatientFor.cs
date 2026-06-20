using Microsoft.Data.SqlClient;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HospitalManagement.Client
{
    public partial class PatientFor : Form
    {
        string connectionString =
           @"Data Source=localhost;Initial Catalog=HospitalDB;Integrated Security=True";

        int selectedPatientId = 0;
        public PatientFor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PatientFor_Load(object sender, EventArgs e)
        {


            LoadPatients();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
        }

        private void LoadPatients()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patients";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();

                adapter.Fill(table);
                
                dataGridView1.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Patients
                                (FullName, Age, Gender, Phone, Address, MedicalHistory)
                                VALUES
                                (@FullName, @Age, @Gender, @Phone, @Address, @MedicalHistory)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@MedicalHistory", txtMedicalHistory.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Patient added successfully.");
            LoadPatients();
            ClearFields();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedPatientId = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["PatientId"].Value);

                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtMedicalHistory.Text = dataGridView1.Rows[e.RowIndex].Cells["MedicalHistory"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == 0)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Patients SET
                                FullName=@FullName,
                                Age=@Age,
                                Gender=@Gender,
                                Phone=@Phone,
                                Address=@Address,
                                MedicalHistory=@MedicalHistory
                                WHERE PatientId=@PatientId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PatientId", selectedPatientId);
                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@MedicalHistory", txtMedicalHistory.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Patient updated successfully.");
            LoadPatients();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == 0)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Patients WHERE PatientId=@PatientId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PatientId", selectedPatientId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Patient deleted successfully.");
            LoadPatients();
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patients WHERE FullName LIKE @FullName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@FullName", "%" + txtName.Text + "%");

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadPatients();
        }

        private void ClearFields()
        {
            selectedPatientId = 0;
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtphone.Clear();
            txtAddress.Clear();
            txtMedicalHistory.Clear();
        }
    }
}

