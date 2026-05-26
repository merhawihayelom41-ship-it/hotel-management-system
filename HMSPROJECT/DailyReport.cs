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
    public partial class DailyReport : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public DailyReport()
        {
            InitializeComponent();
            this.Load += new EventHandler(DailyReport_Load);
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            FetchDailyReportData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Check if there is data in the grid to "send"
                if (dataGridView1.Rows.Count > 0 && dataGridView1.DataSource != null)
                {
                    // 2. Display the success message
                    MessageBox.Show("Report successfully sent to Admin Dashboard!", "Data Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. Optional: Clear the grid or disable the button to prevent double-sending
                    // btnSend.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please click 'View' to load the report before sending.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during transfer: " + ex.Message);
            }


        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            FetchDailyReportData();
        }
        
        private void FetchDailyReportData()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetDailyReport", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);

                    // Binds the combined guest & room columns directly to your DataGridView
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No active registered bookings found.",
                                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report data: " + ex.Message,
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

