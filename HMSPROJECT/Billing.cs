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
    public partial class Billing : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Billing()
        {
            InitializeComponent();
        }
        private void LoadBillingData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ManageBilling", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading data: " + ex.Message); }
        }

        private void ClearFields()
        {
            txtBillingID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;
            txtSearch.Clear();
            txtBillingID.ReadOnly = false;
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
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBillingID.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Billing ID.", "Validation Error");
                txtBillingID.Focus();
                return;
            }        
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Price.", "Validation Error");
                txtPrice.Focus();
                return;
            }
            if (!IsAllLetters(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name must contain only letters.", "Validation Error");
                txtFirstName.Focus();
                return;
            }

            if (!IsAllLetters(txtLastName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name must contain only letters.", "Validation Error");
                txtLastName.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_SaveBilling", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtBillingID.Text));
                    cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing Information Saved!");

                    LoadBillingData();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Save Error: " + ex.Message); }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateBilling", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtBillingID.Text));
                    cmd.Parameters.AddWithValue("@FName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing Updated!");

                    LoadBillingData();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Update Failed: " + ex.Message); }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var result = MessageBox.Show("Are you sure you want to delete this bill?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand cmd = new SqlCommand("sp_DeleteBilling", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", id);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            LoadBillingData();
                            ClearFields();
                            MessageBox.Show("Billing deleted successfully.");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Delete Error: " + ex.Message); }
                }
            }
            else { MessageBox.Show("Please select a bill from the list to delete."); }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_SearchBilling", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 1)
                    {
                        txtBillingID.Text = dt.Rows[0]["BillingID"].ToString();
                        txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                        txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                        cmbStatus.Text = dt.Rows[0]["Status"].ToString();
                        txtPrice.Text = dt.Rows[0]["Price"].ToString();
                        txtBillingID.ReadOnly = true; // Lock ID during update
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No record found.");
                    }

                    txtSearch.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show("Search Error: " + ex.Message); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtBillingID.Text = row.Cells[0].Value?.ToString();
                txtFirstName.Text = row.Cells[1].Value?.ToString();
                txtLastName.Text = row.Cells[2].Value?.ToString();
                cmbStatus.Text = row.Cells[3].Value?.ToString();
                txtPrice.Text = row.Cells[4].Value?.ToString();

                txtBillingID.ReadOnly = true;
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            LoadBillingData();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBillingID.Text))
            {
                MessageBox.Show("Please select a billing record to print.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetReceiptDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BillingID", int.Parse(txtBillingID.Text));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal total = Convert.ToDecimal(reader["Price"]);

                        string receipt = $@"
--------------------------------
          ABC HOTEL
     Tel: +251-xxx-xxxxxx
--------------------------------
Receipt No: {reader["BillingID"].ToString().PadLeft(5, '0')}
Date: {DateTime.Now:dd/MM/yyyy}

Guest: {reader["FirstName"]} {reader["LastName"]}
Room:  {reader["RoomType"]} {reader["RoomNumber"]}
Status: {reader["Status"].ToString().ToUpper()}
--------------------------------
Room Charge:   {total:N2} ETB
Tax (Incl.):   0.00 ETB
--------------------------------
TOTAL:         {total:N2} ETB
--------------------------------

 Thank you for staying with us
--------------------------------";

                        rtbReceipt.Text = receipt;
                        txtBillingID.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtPrice.Clear();
                        cmbStatus.SelectedIndex = -1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating receipt: " + ex.Message);
                }
            }
        }
    }
}
