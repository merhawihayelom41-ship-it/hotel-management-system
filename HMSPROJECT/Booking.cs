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
    public partial class Booking : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Booking()
        {
            InitializeComponent();
        }
        private void LoadBookingData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ManageBooking", conn);
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
            txtBookingID.Clear();
            txtGuestName.Clear();
            txtRoomNumber.Clear();
            cmbRoomType.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            txtSearch.Clear();
            txtBookingID.ReadOnly = false;
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
            if (!int.TryParse(txtBookingID.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Booking ID.", "Validation Error");
                txtBookingID.Focus();
                return;
            }
            if (!int.TryParse(txtRoomNumber.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Room Number.", "Validation Error");
                txtRoomNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGuestName.Text) || !IsAllLetters(txtGuestName.Text))
            {
                MessageBox.Show("Guest Name must contain only letters.", "Validation Error");
                txtGuestName.Focus();
                return;
            }
            if (dtpCheckOut.Value.Date < dtpCheckIn.Value.Date)
            {
                MessageBox.Show("Checkout date cannot be earlier than Check-in date.", "Date Error");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_AddBooking", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", txtBookingID.Text);
                    cmd.Parameters.AddWithValue("@GName", txtGuestName.Text);
                    cmd.Parameters.AddWithValue("@RNum", txtRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@CIn", dtpCheckIn.Value.Date);
                    cmd.Parameters.AddWithValue("@COut", dtpCheckOut.Value.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Confirmed!");
                    LoadBookingData();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Booking Error: " + ex.Message); }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateBooking", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", txtBookingID.Text);
                    cmd.Parameters.AddWithValue("@GName", txtGuestName.Text);
                    cmd.Parameters.AddWithValue("@RNum", txtRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RType", cmbRoomType.Text);
                    cmd.Parameters.AddWithValue("@CIn", dtpCheckIn.Value.Date);
                    cmd.Parameters.AddWithValue("@COut", dtpCheckOut.Value.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Updated!");
                    LoadBookingData();
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
                if (MessageBox.Show("Delete this booking?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand cmd = new SqlCommand("sp_DeleteBooking", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadBookingData();
                            ClearFields();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Delete Error: " + ex.Message); }
                }
            }
            else { MessageBox.Show("Please select a row to delete."); }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("sp_SearchBooking", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 1)
                    {
                        txtBookingID.Text = dt.Rows[0]["BookingID"].ToString();
                        txtGuestName.Text = dt.Rows[0]["GuestName"].ToString();
                        txtRoomNumber.Text = dt.Rows[0]["RoomNumber"].ToString();
                        cmbRoomType.Text = dt.Rows[0]["RoomType"].ToString();
                        dtpCheckIn.Value = Convert.ToDateTime(dt.Rows[0]["CheckIn"]);
                        dtpCheckOut.Value = Convert.ToDateTime(dt.Rows[0]["CheckOut"]);
                        txtBookingID.ReadOnly = true;
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
                txtBookingID.Text = row.Cells[0].Value?.ToString();
                txtGuestName.Text = row.Cells[1].Value?.ToString();
                txtRoomNumber.Text = row.Cells[2].Value?.ToString();
                cmbRoomType.Text = row.Cells[3].Value?.ToString();
                dtpCheckIn.Value = Convert.ToDateTime(row.Cells[4].Value);
                dtpCheckOut.Value = Convert.ToDateTime(row.Cells[5].Value);
                txtBookingID.ReadOnly = true;
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadBookingData();
        }
    }
}
