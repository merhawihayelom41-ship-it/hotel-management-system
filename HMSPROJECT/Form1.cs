using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HMSPROJECT
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=DESKTOP-S6SA92U\SQLEXPRESS;
Initial Catalog=HRMS;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_LoginUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass parameters from your TextBoxes
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text.Trim());

                    con.Open();
                    // This captures the 'Role' string from the database (e.g., "Admin", "User", or "Manager")
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role == "Admin")
                        {textBox2.UseSystemPasswordChar = true;
                            AdminDashboard adminForm = new AdminDashboard();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (role == "User")
                        {
                            userdashBoard userForm = new userdashBoard();
                            userForm.Show();
                            this.Hide();
                        }
                        // --- ADDED MANAGER LOGIC ---
                        else if (role == "Manager")
                        {
                            ManagerDashboard managerForm = new ManagerDashboard();
                            managerForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Role not recognized. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message);
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}

