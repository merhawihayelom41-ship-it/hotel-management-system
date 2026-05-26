namespace HMSPROJECT
{
    partial class Employee
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtEmployeeID = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbGender = new ComboBox();
            txtContactNumber = new TextBox();
            label6 = new Label();
            txtSalary = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Addbtn = new Button();
            Updatebtn = new Button();
            Deletebtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 46);
            panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.emplo;
            pictureBox1.Location = new Point(108, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 20;
            label1.Text = " ADD EMPLOYEE";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(12, 82);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(100, 23);
            txtEmployeeID.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 23;
            label2.Text = "Employee ID";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(156, 82);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 64);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 25;
            label3.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(294, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(300, 64);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 27;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(460, 64);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 29;
            label5.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(445, 82);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(116, 23);
            cmbGender.TabIndex = 30;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(12, 138);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(100, 23);
            txtContactNumber.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 120);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 31;
            label6.Text = "Contact Number";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(156, 138);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(162, 120);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 33;
            label7.Text = "Salary";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 108);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(18, 304);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 36;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(162, 304);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 37;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(349, 304);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 38;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(dataGridView1);
            Controls.Add(txtSalary);
            Controls.Add(label7);
            Controls.Add(txtContactNumber);
            Controls.Add(label6);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtEmployeeID);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox txtEmployeeID;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private ComboBox cmbGender;
        private TextBox txtContactNumber;
        private Label label6;
        private TextBox txtSalary;
        private Label label7;
        private DataGridView dataGridView1;
        private Button Addbtn;
        private Button Updatebtn;
        private Button Deletebtn;
    }
}