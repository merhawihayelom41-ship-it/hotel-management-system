namespace HMSPROJECT
{
    partial class Guest
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
            label2 = new Label();
            Deletebtn = new Button();
            Updatebtn = new Button();
            Addbtn = new Button();
            txtSearch = new TextBox();
            searchbtn = new Button();
            label1 = new Label();
            txtGuestID = new TextBox();
            label6 = new Label();
            label4 = new Label();
            txtContactNumber = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 34);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 21;
            label2.Text = " MANAGE GUEST";
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(240, 304);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 43;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(135, 304);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 42;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(29, 304);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 41;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(435, 304);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 23);
            txtSearch.TabIndex = 45;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(354, 304);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 44;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(276, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 55;
            label1.Text = "Last name";
            label1.Click += label1_Click;
            // 
            // txtGuestID
            // 
            txtGuestID.Location = new Point(12, 55);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.Size = new Size(100, 23);
            txtGuestID.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 37);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 53;
            label6.Text = "Guest ID";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(417, 37);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 51;
            label4.Text = "Contact number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(417, 55);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(100, 23);
            txtContactNumber.TabIndex = 48;
            txtContactNumber.TextChanged += txtContactNumber_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(276, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(135, 37);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 46;
            label3.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(135, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 56;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(373, 197);
            dataGridView1.TabIndex = 57;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rec;
            pictureBox1.Location = new Point(391, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(txtGuestID);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtContactNumber);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(searchbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Guest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest";
            Load += Guest_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button Deletebtn;
        private Button Updatebtn;
        private Button Addbtn;
        private TextBox txtSearch;
        private Button searchbtn;
        private Label label1;
        private TextBox txtGuestID;
        private Label label6;
        private Label label4;
        private TextBox txtContactNumber;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}