using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HMSPROJECT
{
    public partial class Employee : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Employee()
        {
            InitializeComponent();
        }
        private void LoadEmployeeData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // Simple select to get all employees
                    string query = "SELECT * FROM Employees";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the data to your grid
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        private void ClearFields()
        {
            // Clear all textboxes
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNumber.Clear();
            txtSalary.Clear();

            // Reset ComboBox to the "unselected" state
            if (cmbGender.Items.Count > 0)
            {
                cmbGender.SelectedIndex = -1;
            }
            txtEmployeeID.ReadOnly = false;
            txtEmployeeID.Focus();
        }
        private bool IsAllLetters(string text)
        {
            foreach (char c in text)
            {           
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeID.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Employee ID.", "Validation Error");
                txtEmployeeID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !IsAllLetters(txtFirstName.Text))
            {
                MessageBox.Show("First Name must contain only letters.", "Validation Error");
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text) || !IsAllLetters(txtLastName.Text))
            {
                MessageBox.Show("Last Name must contain only letters.", "Validation Error");
                txtLastName.Focus();
                return;
            }   
            if (txtContactNumber.Text.Length != 10 || !long.TryParse(txtContactNumber.Text, out _))
            {
                MessageBox.Show("Contact Number must be exactly 10 digits (0-9).", "Validation Error");
                txtContactNumber.Focus();
                return;
            }
            if (!decimal.TryParse(txtSalary.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Salary.", "Validation Error");
                txtSalary.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_AddEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContactNumber.Text);

                    cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = decimal.Parse(txtSalary.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Added Successfully!");

                    LoadEmployeeData(); 
                    ClearFields();      
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];         
                txtEmployeeID.Text = row.Cells[0].Value?.ToString();
                txtFirstName.Text = row.Cells[1].Value?.ToString();
                txtLastName.Text = row.Cells[2].Value?.ToString();
                cmbGender.Text = row.Cells[3].Value?.ToString();
                txtContactNumber.Text = row.Cells[4].Value?.ToString();
                txtSalary.Text = row.Cells[5].Value?.ToString();

                txtEmployeeID.ReadOnly = true;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Selection Error: Please click a row in the table first to load the employee data.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContactNumber.Text);

                    if (decimal.TryParse(txtSalary.Text, out decimal salaryVal))
                    {
                        cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = salaryVal;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid numeric salary.");
                        return;
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Record Updated Successfully!");

                    LoadEmployeeData(); // Refresh the grid
                    ClearFields();      
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error: " + ex.Message);
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the Employee ID from the first cell of the selected row
                string selectedID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // 2. Safety First: Always ask for confirmation before deleting
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Employee ID: {selectedID}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("sp_DeleteEmployee", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", selectedID);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Employee deleted successfully.");

                            // 3. Refresh the UI
                            LoadEmployeeData();
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting record: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please click on the far left of a row to select the entire record first.");
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            txtContactNumber.MaxLength = 10;
            LoadEmployeeData();
        }
    }
}
