namespace HMSPROJECT
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            Reportbtn = new Button();
            Addroomsbtn = new Button();
            Employeebtn = new Button();
            logoutBtn = new Button();
            Settingbtn = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Reportbtn);
            panel1.Controls.Add(Addroomsbtn);
            panel1.Controls.Add(Employeebtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(Settingbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 495);
            panel1.TabIndex = 0;
            // 
            // Reportbtn
            // 
            Reportbtn.FlatAppearance.BorderSize = 0;
            Reportbtn.FlatStyle = FlatStyle.Flat;
            Reportbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reportbtn.ForeColor = Color.White;
            Reportbtn.Location = new Point(40, 160);
            Reportbtn.Name = "Reportbtn";
            Reportbtn.Size = new Size(75, 23);
            Reportbtn.TabIndex = 12;
            Reportbtn.Text = "Report";
            Reportbtn.UseVisualStyleBackColor = true;
            Reportbtn.Click += Reportbtn_Click;
            // 
            // Addroomsbtn
            // 
            Addroomsbtn.FlatAppearance.BorderSize = 0;
            Addroomsbtn.FlatStyle = FlatStyle.Flat;
            Addroomsbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addroomsbtn.ForeColor = Color.White;
            Addroomsbtn.Location = new Point(40, 206);
            Addroomsbtn.Name = "Addroomsbtn";
            Addroomsbtn.Size = new Size(88, 23);
            Addroomsbtn.TabIndex = 11;
            Addroomsbtn.Text = "Add Rooms";
            Addroomsbtn.UseVisualStyleBackColor = true;
            Addroomsbtn.Click += Addroomsbtn_Click;
            // 
            // Employeebtn
            // 
            Employeebtn.FlatAppearance.BorderSize = 0;
            Employeebtn.FlatStyle = FlatStyle.Flat;
            Employeebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employeebtn.ForeColor = Color.White;
            Employeebtn.Location = new Point(40, 256);
            Employeebtn.Name = "Employeebtn";
            Employeebtn.Size = new Size(75, 23);
            Employeebtn.TabIndex = 10;
            Employeebtn.Text = "Employee";
            Employeebtn.UseVisualStyleBackColor = true;
            Employeebtn.Click += Employeebtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Navy;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(14, 390);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 33);
            logoutBtn.TabIndex = 9;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += button5_Click;
            // 
            // Settingbtn
            // 
            Settingbtn.FlatAppearance.BorderSize = 0;
            Settingbtn.FlatStyle = FlatStyle.Flat;
            Settingbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settingbtn.ForeColor = Color.White;
            Settingbtn.Location = new Point(40, 299);
            Settingbtn.Name = "Settingbtn";
            Settingbtn.Size = new Size(75, 23);
            Settingbtn.TabIndex = 8;
            Settingbtn.Text = "Setting";
            Settingbtn.UseVisualStyleBackColor = true;
            Settingbtn.Click += Settingbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(9, 104);
            label3.Name = "label3";
            label3.Size = new Size(171, 13);
            label3.TabIndex = 4;
            label3.Text = "HOTEL MANAGEMENT SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(179, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 48);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 11);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 2;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(675, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(202, 87);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(619, 378);
            panelContainer.TabIndex = 9;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 496);
            Controls.Add(panelContainer);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button logoutBtn;
        private Button Settingbtn;
        private Button Reportbtn;
        private Button Addroomsbtn;
        private Button Employeebtn;
        private PictureBox pictureBox1;
        private Panel panelContainer;
    }
}