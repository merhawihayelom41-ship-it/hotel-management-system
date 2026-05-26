namespace HMSPROJECT
{
    partial class addingroom
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
            label1 = new Label();
            comboBoxRoomNo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            comboBoxRoomType = new ComboBox();
            txtRoomID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Deletebtn = new Button();
            Updatebtn = new Button();
            Addbtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 46);
            panel2.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 20;
            label1.Text = " ADDING ROOMS";
            // 
            // comboBoxRoomNo
            // 
            comboBoxRoomNo.FormattingEnabled = true;
            comboBoxRoomNo.Items.AddRange(new object[] { "1_single", "2_single", "3_single", "4_single", "5_single", "6_double", "7_double", "8_double", "9_double", "10_double" });
            comboBoxRoomNo.Location = new Point(168, 66);
            comboBoxRoomNo.Name = "comboBoxRoomNo";
            comboBoxRoomNo.Size = new Size(106, 23);
            comboBoxRoomNo.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(168, 48);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 30;
            label6.Text = "Room Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(410, 48);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 29;
            label5.Text = "Status";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active ", "Inactive", "Occupied" });
            comboBoxStatus.Location = new Point(410, 66);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(116, 23);
            comboBoxStatus.TabIndex = 28;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Items.AddRange(new object[] { "single", "double" });
            comboBoxRoomType.Location = new Point(284, 66);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(116, 23);
            comboBoxRoomType.TabIndex = 27;
            comboBoxRoomType.SelectedIndexChanged += comboBoxRoomType_SelectedIndexChanged;
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(53, 66);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(100, 23);
            txtRoomID.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(284, 48);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 25;
            label3.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 24;
            label2.Text = "Room ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 143);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(467, 284);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 35;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(247, 284);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 34;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(53, 284);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 33;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // addingroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxRoomNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxRoomType);
            Controls.Add(txtRoomID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "addingroom";
            Text = "addingroom";
            Load += addingroom_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private ComboBox comboBoxRoomNo;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxRoomType;
        private TextBox txtRoomID;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button Deletebtn;
        private Button Updatebtn;
        private Button Addbtn;
    }
}