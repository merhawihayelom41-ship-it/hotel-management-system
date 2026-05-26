namespace HMSPROJECT
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtRoomID = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            cmbRoomType = new ComboBox();
            cmbStatus = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            Deletebtn = new Button();
            Updatebtn = new Button();
            Addbtn = new Button();
            pictureBox2 = new PictureBox();
            searchbtn = new Button();
            txtSearch = new TextBox();
            cmbRoomNumber = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel2.Size = new Size(603, 34);
            panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 75);
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
            label1.Size = new Size(138, 20);
            label1.TabIndex = 20;
            label1.Text = " MANAGE ROOMS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(407, 175);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(27, 54);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(100, 23);
            txtRoomID.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 36);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 34;
            label6.Text = "Room ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(254, 36);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 27;
            label3.Text = "Room Type";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(491, 54);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 29;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "single", "double" });
            cmbRoomType.Location = new Point(256, 54);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(96, 23);
            cmbRoomType.TabIndex = 30;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active ", "Inactive", "Occupied" });
            cmbStatus.Location = new Point(362, 54);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(116, 23);
            cmbStatus.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(491, 36);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 32;
            label4.Text = "Price($)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(362, 36);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 33;
            label5.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(133, 36);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 37;
            label2.Text = "Room Number";
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(236, 304);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 40;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(118, 304);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 39;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(18, 304);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 38;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(423, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(349, 304);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 42;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(430, 304);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 43;
            // 
            // cmbRoomNumber
            // 
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.Items.AddRange(new object[] { "1_single", "2_single", "3_single", "4_single", "5_single", "6_double", "7_double", "8_double", "9_double", "10_double" });
            cmbRoomNumber.Location = new Point(133, 54);
            cmbRoomNumber.Name = "cmbRoomNumber";
            cmbRoomNumber.Size = new Size(103, 23);
            cmbRoomNumber.TabIndex = 44;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(cmbRoomNumber);
            Controls.Add(txtSearch);
            Controls.Add(searchbtn);
            Controls.Add(pictureBox2);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(label2);
            Controls.Add(txtRoomID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Controls.Add(cmbRoomType);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            Load += Rooms_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtRoomID;
        private Label label6;
        private Label label3;
        private TextBox txtPrice;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private Label label4;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox1;
        private Button Deletebtn;
        private Button Updatebtn;
        private Button Addbtn;
        private PictureBox pictureBox2;
        private Button searchbtn;
        private TextBox txtSearch;
        private ComboBox cmbRoomNumber;
    }
}