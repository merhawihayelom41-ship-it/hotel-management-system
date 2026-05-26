namespace HMSPROJECT
{
    partial class userdashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userdashBoard));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            guestbtn = new Button();
            roomsbtn = new Button();
            Employeebtn = new Button();
            logoutbtn = new Button();
            billingbtn = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(184, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(671, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(184, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 70);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 11);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "USER DASHBOARD";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(guestbtn);
            panel1.Controls.Add(roomsbtn);
            panel1.Controls.Add(Employeebtn);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(billingbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 499);
            panel1.TabIndex = 5;
            // 
            // guestbtn
            // 
            guestbtn.FlatAppearance.BorderSize = 0;
            guestbtn.FlatStyle = FlatStyle.Flat;
            guestbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestbtn.ForeColor = Color.White;
            guestbtn.Location = new Point(40, 160);
            guestbtn.Name = "guestbtn";
            guestbtn.Size = new Size(75, 23);
            guestbtn.TabIndex = 12;
            guestbtn.Text = "Guest";
            guestbtn.UseVisualStyleBackColor = true;
            guestbtn.Click += guestbtn_Click;
            // 
            // roomsbtn
            // 
            roomsbtn.FlatAppearance.BorderSize = 0;
            roomsbtn.FlatStyle = FlatStyle.Flat;
            roomsbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomsbtn.ForeColor = Color.White;
            roomsbtn.Location = new Point(40, 206);
            roomsbtn.Name = "roomsbtn";
            roomsbtn.Size = new Size(88, 23);
            roomsbtn.TabIndex = 11;
            roomsbtn.Text = " Rooms";
            roomsbtn.UseVisualStyleBackColor = true;
            roomsbtn.Click += roomsbtn_Click;
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
            Employeebtn.Text = "Booking";
            Employeebtn.UseVisualStyleBackColor = true;
            Employeebtn.Click += Employeebtn_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Navy;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(14, 390);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(75, 33);
            logoutbtn.TabIndex = 9;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // billingbtn
            // 
            billingbtn.FlatAppearance.BorderSize = 0;
            billingbtn.FlatStyle = FlatStyle.Flat;
            billingbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingbtn.ForeColor = Color.White;
            billingbtn.Location = new Point(40, 299);
            billingbtn.Name = "billingbtn";
            billingbtn.Size = new Size(75, 23);
            billingbtn.TabIndex = 8;
            billingbtn.Text = "Billing";
            billingbtn.UseVisualStyleBackColor = true;
            billingbtn.Click += billingbtn_Click;
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
            // panelContainer
            // 
            panelContainer.Location = new Point(209, 76);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(619, 378);
            panelContainer.TabIndex = 8;
            // 
            // userdashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 496);
            Controls.Add(panelContainer);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "userdashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userdashBoard";
            Load += userdashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button guestbtn;
        private Button roomsbtn;
        private Button Employeebtn;
        private Button logoutbtn;
        private Button billingbtn;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panelContainer;
    }
}