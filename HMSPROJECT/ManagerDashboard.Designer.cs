namespace HMSPROJECT
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            panel1 = new Panel();
            DailyReportbtn = new Button();
            Addingroomsbtn = new Button();
            logoutBtn = new Button();
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
            panel1.Controls.Add(DailyReportbtn);
            panel1.Controls.Add(Addingroomsbtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 495);
            panel1.TabIndex = 1;
            // 
            // DailyReportbtn
            // 
            DailyReportbtn.FlatAppearance.BorderSize = 0;
            DailyReportbtn.FlatStyle = FlatStyle.Flat;
            DailyReportbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DailyReportbtn.ForeColor = Color.White;
            DailyReportbtn.Location = new Point(27, 161);
            DailyReportbtn.Name = "DailyReportbtn";
            DailyReportbtn.Size = new Size(101, 23);
            DailyReportbtn.TabIndex = 12;
            DailyReportbtn.Text = "Daily Report";
            DailyReportbtn.UseVisualStyleBackColor = true;
            DailyReportbtn.Click += DailyReportbtn_Click;
            // 
            // Addingroomsbtn
            // 
            Addingroomsbtn.FlatAppearance.BorderSize = 0;
            Addingroomsbtn.FlatStyle = FlatStyle.Flat;
            Addingroomsbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addingroomsbtn.ForeColor = Color.White;
            Addingroomsbtn.Location = new Point(12, 206);
            Addingroomsbtn.Name = "Addingroomsbtn";
            Addingroomsbtn.Size = new Size(116, 23);
            Addingroomsbtn.TabIndex = 11;
            Addingroomsbtn.Text = "Adding Rooms";
            Addingroomsbtn.UseVisualStyleBackColor = true;
            Addingroomsbtn.Click += Addingroomsbtn_Click;
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
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(-1, 104);
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
            panel2.Location = new Point(171, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 48);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 12);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 2;
            label1.Text = "MANAGER DASHBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(683, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(206, 79);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(619, 378);
            panelContainer.TabIndex = 10;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 496);
            Controls.Add(panelContainer);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManagerDashboard";
            Text = "ManagerDashboard";
            Load += ManagerDashboard_Load;
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
        private Button DailyReportbtn;
        private Button Addingroomsbtn;
        private Button logoutBtn;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelContainer;
    }
}