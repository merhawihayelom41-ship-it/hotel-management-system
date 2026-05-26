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
    public partial class Reportadmin : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Reportadmin()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetTotalAdminReport", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);

                    // Reset and bind data
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;

                    // Auto-style for readability
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Safety check: Is the first cell a valid GuestID (numeric)?
                string firstCellValue = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int guestIdToDelete;

                if (!int.TryParse(firstCellValue, out guestIdToDelete))
                {
                    MessageBox.Show("You can only delete guest records. Summary/Total rows cannot be deleted.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Guest ID {guestIdToDelete} and all related data?",
                                                       "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("sp_DeleteAdminReportRecord", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@GuestID", guestIdToDelete);

                            con.Open();
                            int rows = (int)cmd.ExecuteScalar();

                            if (rows > 0)
                            {
                                MessageBox.Show("Record permanently removed.");
                                viewbtn_Click(sender, e); // Refresh the report automatically
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Delete failed: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a guest row from the table first.");
            }
        }
    }
}
     

