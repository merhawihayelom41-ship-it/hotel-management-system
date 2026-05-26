using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMSPROJECT
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void LoadForm(Form form)
        {
            panelContainer.Visible = true;
            panelContainer.BringToFront();

            panelContainer.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;

            form.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                           "Are you sure you want to logout?",
                           "Logout",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                       );

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Reportadmin());
        }

        private void Addroomsbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Addrooms());
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Employee());
        }

        private void Settingbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new setting());
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
        }
    }
}
