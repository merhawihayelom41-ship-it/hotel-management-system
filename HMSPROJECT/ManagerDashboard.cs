using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMSPROJECT
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }
        private void LoadFormIntoPanel(Form form)
        {
            // Make the panel visible once a button is clicked
            panelContainer.Visible = true;
            panelContainer.BringToFront();

            // Clear any previous form from the panel
            if (panelContainer.Controls.Count > 0)
                panelContainer.Controls.RemoveAt(0);

            // Setup the new form
            form.TopLevel = false;                          // Allows form inside a control
            form.FormBorderStyle = FormBorderStyle.None;     // Removes title bar
            form.Dock = DockStyle.Fill;                      // Fits the panel exactly

            // Add to panel and show
            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;
            form.Show();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
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

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
        }

        private void DailyReportbtn_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new DailyReport());
        }

        private void Addingroomsbtn_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new addingroom());
        }
    }
}
