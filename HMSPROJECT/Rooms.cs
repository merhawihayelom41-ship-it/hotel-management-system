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
    public partial class Rooms : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        List<string> allRooms = new List<string> {
            "1_single", "2_single", "3_single", "4_single", "5_single",
            "6_double", "7_double", "8_double", "9_double", "10_double"
        };
        public Rooms()
        {
            InitializeComponent();
        }
        private void LoadRoomData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Managerooms", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh(); // Force the UI to update
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void ClearFields()
        {
            // Clear TextBoxes
            txtRoomID.Clear();
            txtPrice.Clear();
            txtSearch.Clear();

            // Fix: Room Number is now a ComboBox
            cmbRoomNumber.SelectedIndex = -1;
            cmbRoomNumber.Text = "";

            // Reset other ComboBoxes
            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            // Reset ReadOnly state and focus for the next entry
            txtRoomID.ReadOnly = false;
            txtRoomID.Focus();
        }
        private void RefreshRoomComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // Get all room numbers currently registered in the database
                    SqlDataAdapter da = new SqlDataAdapter("SELECT RoomNumber FROM Managerooms", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Create a list of occupied room numbers
                    List<string> occupiedRooms = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        occupiedRooms.Add(row["RoomNumber"].ToString());
                    }

                    // Clear current items and only add those NOT in the occupied list
                    cmbRoomNumber.Items.Clear();
                    foreach (string room in allRooms)
                    {
                        if (!occupiedRooms.Contains(room))
                        {
                            cmbRoomNumber.Items.Add(room);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error refreshing rooms: " + ex.Message); }
            }
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {         
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRoomID.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Room ID.", "Validation Error");
                txtRoomID.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Price (e.g., 500 or 500.50).", "Validation Error");
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbRoomNumber.Text) || string.IsNullOrEmpty(cmbRoomType.Text))
            {
                MessageBox.Show("Please select both a Room Number and Room Type.", "Validation Error");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_AddRoom", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", txtRoomID.Text);
                    cmd.Parameters.AddWithValue("@RNum", cmbRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Added Successfully!");

                    LoadRoomData();
                    ClearFields();
                    RefreshRoomComboBox();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateRoom", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomID", txtRoomID.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", cmbRoomNumber.Text); // ComboBox
                    cmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated!");
                    LoadRoomData();
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
                var confirmResult = MessageBox.Show("Delete Room " + id + "?", "Confirm", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand cmd = new SqlCommand("sp_DeleteRoom", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", id);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Room deleted successfully.");
                            LoadRoomData();
                            ClearFields();
                            RefreshRoomComboBox();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // 1. Ensure the procedure name matches your SQL exactly: sp_searchroom
                    SqlCommand cmd = new SqlCommand("sp_SearchRoom", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 2. Ensure the parameter name matches your SQL: @SearchValue
                    cmd.Parameters.AddWithValue("@SearchValue", txtSearch.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 3. Update the grid with the results
                    dataGridView1.DataSource = dt;

                    // 4. If exactly one room is found, populate the top controls automatically
                    if (dt.Rows.Count == 1)
                    {
                        txtRoomID.Text = dt.Rows[0]["RoomID"].ToString();

                        // Use the ComboBox name for Room Number
                        cmbRoomNumber.Text = dt.Rows[0]["RoomNumber"].ToString();

                        cmbRoomType.Text = dt.Rows[0]["RoomType"].ToString();
                        cmbStatus.Text = dt.Rows[0]["Status"].ToString();
                        txtPrice.Text = dt.Rows[0]["Price"].ToString();

                        // Set to ReadOnly so the ID isn't changed during a potential Update
                        txtRoomID.ReadOnly = true;
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No room found matching that search term.");
                        LoadRoomData(); // Optional: Reload all rooms if search fails
                    }

                    // Clear search box for next use
                    txtSearch.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtRoomID.Text = row.Cells[0].Value?.ToString() ?? "";
                cmbRoomNumber.Text = row.Cells[1].Value?.ToString() ?? ""; // ComboBox
                cmbRoomType.Text = row.Cells[2].Value?.ToString() ?? "";
                cmbStatus.Text = row.Cells[3].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells[4].Value?.ToString() ?? "";

                txtRoomID.ReadOnly = true;
            }
        }

       

        private void Rooms_Load(object sender, EventArgs e)
        {
            LoadRoomData();
            RefreshRoomComboBox();
        }
    }
}
