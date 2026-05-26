using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMSPROJECT
{
    public partial class userdashBoard : Form
    {
        public userdashBoard()
        {
            InitializeComponent();
        }
        private void LoadForm(Form form)
        {
            panelContainer.Visible = true;       // show panel
            panelContainer.BringToFront();       // bring to front

            panelContainer.Controls.Clear();     // clear old form

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;

            form.Show();
        }
        private void guestbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Guest());
        }

        private void roomsbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Rooms());
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Booking());
        }

        private void billingbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Billing());
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1(); // Form1 is your login form
                loginForm.Show();
                this.Close(); // Close the dashboard entirely
            }
        }

        private void userdashBoard_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
        }
    }
}
