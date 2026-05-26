using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace HMSPROJECT
{
    public partial class Guest : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Guest()
        {
            InitializeComponent();
        }
        private bool IsValidContact(string contact)
        {
            // Checks if the string is exactly 10 digits long and contains only numbers
            return Regex.IsMatch(contact, @"^[0-9]{10}$");
        }
        private void LoadGuestData()
        {
            // FIX: Removed the "YOUR_SERVER" line so it uses your global connString
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Guests", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            txtGuestID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNumber.Clear();

            // Reset Search box if you have one
            txtSearch.Clear();

            // Unlock the ID field for new entries
            txtGuestID.ReadOnly = false;

            // Optional: Set focus back to the first field
            txtGuestID.Focus();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (!int.TryParse(txtGuestID.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Guest ID.", "Validation Error");
                txtGuestID.Focus();
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

            if (txtContactNumber.Text.Length != 10)
            {
                MessageBox.Show("Contact Number must be exactly 10 digits.", "Validation Error");
                txtContactNumber.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_AddGuest", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", txtGuestID.Text);
                    cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContactNumber.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest Added successfully!");

                    LoadGuestData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateGuest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", txtGuestID.Text);
                cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContactNumber.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guest Updated!");
                LoadGuestData();
                ClearFields();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_DeleteGuest", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadGuestData();
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Fill textboxes based on the column order in your Guests table
                // row.Cells[index] refers to GuestID, FirstName, LastName, ContactNumber
                txtGuestID.Text = row.Cells[0].Value?.ToString();
                txtFirstName.Text = row.Cells[1].Value?.ToString();
                txtLastName.Text = row.Cells[2].Value?.ToString();
                txtContactNumber.Text = row.Cells[3].Value?.ToString();

                // Lock the ID so it can't be changed during an update
                txtGuestID.ReadOnly = true;
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_SearchGuest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Update the grid
                dataGridView1.DataSource = dt;

                // NEW: If we found exactly what we were looking for, fill the boxes
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtGuestID.Text = row["GuestID"]?.ToString() ?? "";
                    txtFirstName.Text = row["FirstName"]?.ToString() ?? "";
                    txtLastName.Text = row["LastName"]?.ToString() ?? "";
                    txtContactNumber.Text = row["ContactNumber"]?.ToString() ?? "";

                    // Lock ID since we are viewing an existing record
                    txtGuestID.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No guest found with that ID or Name.");
                    ClearFields();
                }
            }
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            txtContactNumber.MaxLength = 10;
            LoadGuestData();
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            string cleaned = Regex.Replace(txtContactNumber.Text, @"[^0-9]", "");

            if (txtContactNumber.Text != cleaned)
            {
                txtContactNumber.Text = cleaned;
                // Move the cursor to the end of the text
                txtContactNumber.SelectionStart = txtContactNumber.Text.Length;
            }
        }
    }
}
