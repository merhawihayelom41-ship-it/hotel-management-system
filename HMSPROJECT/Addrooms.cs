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
    public partial class Addrooms : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Addrooms()
        {
            InitializeComponent();
        }
        private void LoadRooms()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rooms", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Addrooms_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
        private void ClearFields()
        {
            txtRoomID.Clear();
            price.Clear();

            // Reset all ComboBoxes
            cmbRoomNumber.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            txtRoomID.ReadOnly = false;
            txtRoomID.Focus();
        }
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Please enter a valid numeric Room ID.");
                txtRoomID.Focus();
                return;
            }       
            if (!decimal.TryParse(price.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Price.");
                price.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_addrooms", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomID", txtRoomID.Text);
                    // Use .Text from the ComboBox for Room Number
                    cmd.Parameters.AddWithValue("@RoomNumber", cmbRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", price.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Added Successfully!");

                    LoadRooms();
                    ClearFields();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_updaterooms", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomID", txtRoomID.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", cmbRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", price.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated Successfully!");

                    LoadRooms();
                    ClearFields();
                    txtRoomID.ReadOnly = false;
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get RoomID from the first cell of the selected row
                string roomIdToDelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Room " + roomIdToDelete + "?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("sp_DeleteRoom", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@RoomID", roomIdToDelete);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Room Deleted Successfully!");
                            LoadRooms();
                            ClearFields();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a full row in the grid to delete.");
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtRoomID.Text = row.Cells[0].Value.ToString();
                cmbRoomNumber.Text = row.Cells[1].Value.ToString(); // Set ComboBox text
                cmbRoomType.Text = row.Cells[2].Value.ToString();
                cmbStatus.Text = row.Cells[3].Value.ToString();
                price.Text = row.Cells[4].Value.ToString();

                txtRoomID.ReadOnly = true;
            }
        }
    }
}
