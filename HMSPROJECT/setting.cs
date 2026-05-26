using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMSPROJECT
{
    public partial class setting : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        string originalUsername = "";
        public setting()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(originalUsername))
            {
                MessageBox.Show("Please select a user from the table first.");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateUserCredentials", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters matching our modified SQL procedure
                    cmd.Parameters.AddWithValue("@OldUsername", originalUsername);
                    cmd.Parameters.AddWithValue("@NewUsername", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewPassword", textBox2.Text.Trim());

                    con.Open();
                    int rowsAffected = Convert.ToInt32(cmd.ExecuteScalar());

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear and Refresh
                        textBox1.Clear();
                        textBox2.Clear();
                        originalUsername = "";
                        viewsecurityBtn_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void viewsecurityBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    string query = "SELECT UserID, Username, Password, Role FROM Users";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Store the original name so we can find it in the DB later
                originalUsername = row.Cells["Username"].Value.ToString();

                // Fill textboxes for editing
                textBox1.Text = originalUsername;
                textBox2.Text = row.Cells["Password"].Value.ToString();
            }
        }
    }
}

