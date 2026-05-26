using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HMSPROJECT
{
    public partial class addingroom : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public addingroom()
        {
            InitializeComponent();
            this.Load += new EventHandler(addingroom_Load);
        }
        // Full list of possible rooms
        List<string> allRooms = new List<string> {
    "1_single", "2_single", "3_single", "4_single", "5_single",
    "6_double", "7_double", "8_double", "9_double", "10_double"
};

        private void RefreshRoomList()
        {
            comboBoxRoomNo.Items.Clear();

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT RoomNumber FROM addingroom", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Get list of rooms already registered in database
                List<string> registeredRooms = dt.AsEnumerable()
                                                 .Select(r => r.Field<string>("RoomNumber"))
                                                 .ToList();

                // Only add rooms to ComboBox if they are NOT in the database
                foreach (var room in allRooms)
                {
                    if (!registeredRooms.Contains(room))
                    {
                        comboBoxRoomNo.Items.Add(room);
                    }
                }

                // Also refresh DataGridView to show current records
                SqlDataAdapter daGrid = new SqlDataAdapter("SELECT * FROM addingroom", con);
                DataTable dtGrid = new DataTable();
                daGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
            }
        }
        private void ClearControls()
        {
            // Clear the Room ID text box
            txtRoomID.Clear();

            // Reset ComboBoxes to no selection
            comboBoxRoomNo.SelectedIndex = -1;
            comboBoxRoomType.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;

            // Refresh the available room list so the ComboBox is updated
            RefreshRoomList();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomID.Text) ||
         comboBoxRoomNo.SelectedItem == null ||
         comboBoxRoomType.SelectedItem == null ||
         comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields and select items from the menus before adding.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_AddRoomManager", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RoomID", txtRoomID.Text);
                cmd.Parameters.AddWithValue("@RoomNumber", comboBoxRoomNo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@RoomType", comboBoxRoomType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Added!");

                // This will automatically clear fields and refresh your data grid view
                ClearControls();
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateRoomManager", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RoomID", txtRoomID.Text);
                cmd.Parameters.AddWithValue("@RoomNumber", comboBoxRoomNo.Text);
                cmd.Parameters.AddWithValue("@RoomType", comboBoxRoomType.Text);
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!");
                RefreshRoomList();
                ClearControls();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteRoomManager", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomID", txtRoomID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Deleted!");

                RefreshRoomList(); // This adds the room back to the ComboBox
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtRoomID.Text = row.Cells["RoomID"].Value.ToString();
                // Note: For Update, you might need to temporarily add the current 
                // room number back to the combo box so it can be selected.
                if (!comboBoxRoomNo.Items.Contains(row.Cells["RoomNumber"].Value.ToString()))
                {
                    comboBoxRoomNo.Items.Add(row.Cells["RoomNumber"].Value.ToString());
                }
                comboBoxRoomNo.SelectedItem = row.Cells["RoomNumber"].Value.ToString();
            }
        }

        private void addingroom_Load(object sender, EventArgs e)
        {
            RefreshRoomList();
        }
    }
}
