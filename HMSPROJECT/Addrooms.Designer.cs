namespace HMSPROJECT
{
    partial class Addrooms
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtRoomID = new TextBox();
            price = new TextBox();
            cmbRoomType = new ComboBox();
            cmbStatus = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            Addbtn = new Button();
            Updatebtn = new Button();
            Deletebtn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            cmbRoomNumber = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 161);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Room ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(243, 67);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Room Type";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(12, 85);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(100, 23);
            txtRoomID.TabIndex = 11;
            // 
            // price
            // 
            price.Location = new Point(491, 85);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 12;
            price.TextChanged += price_TextChanged;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "single", "double" });
            cmbRoomType.Location = new Point(243, 85);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(116, 23);
            cmbRoomType.TabIndex = 13;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active ", "Inactive", "Occupied" });
            cmbStatus.Location = new Point(369, 85);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(116, 23);
            cmbStatus.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(491, 67);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 15;
            label4.Text = "Price(Birr)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(369, 67);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Status";
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(49, 304);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 17;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(243, 304);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 18;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(463, 304);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 19;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 20;
            label1.Text = " ADD ROOMS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 46);
            panel2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(127, 67);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 22;
            label6.Text = "Room Number";
            // 
            // cmbRoomNumber
            // 
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.Items.AddRange(new object[] { "1_single", "2_single", "3_single", "4_single", "5_single", "6_double", "7_double", "8_double", "9_double", "10_double" });
            cmbRoomNumber.Location = new Point(127, 85);
            cmbRoomNumber.Name = "cmbRoomNumber";
            cmbRoomNumber.Size = new Size(106, 23);
            cmbRoomNumber.TabIndex = 23;
            // 
            // Addrooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(cmbRoomNumber);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Controls.Add(cmbRoomType);
            Controls.Add(price);
            Controls.Add(txtRoomID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Addrooms";
            Text = "Addrooms";
            Load += Addrooms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox txtRoomID;
        private TextBox price;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private Label label4;
        private Label label5;
        private Button Addbtn;
        private Button Updatebtn;
        private Button Deletebtn;
        private Label label1;
        private Panel panel2;
        private Label label6;
        private ComboBox cmbRoomNumber;
    }
}