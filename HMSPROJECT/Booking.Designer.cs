namespace HMSPROJECT
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtBookingID = new TextBox();
            label6 = new Label();
            txtGuestName = new TextBox();
            label3 = new Label();
            cmbRoomType = new ComboBox();
            txtRoomNumber = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            searchbtn = new Button();
            Deletebtn = new Button();
            Updatebtn = new Button();
            Bookbtn = new Button();
            pictureBox1 = new PictureBox();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
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
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 21;
            label2.Text = " MANAGE BOOKING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 41;
            label1.Text = "Guest name";
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(12, 54);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(100, 23);
            txtBookingID.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 36);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 39;
            label6.Text = "Booking ID";
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(133, 54);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(100, 23);
            txtGuestName.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(239, 36);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 45;
            label3.Text = "Room Number";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "single", "double" });
            cmbRoomType.Location = new Point(371, 54);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(116, 23);
            cmbRoomType.TabIndex = 44;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(239, 54);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(100, 23);
            txtRoomNumber.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(371, 36);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 42;
            label4.Text = "Room Type";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(352, 147);
            dataGridView1.TabIndex = 58;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(427, 304);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 63;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(346, 304);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 62;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(233, 304);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 61;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(115, 304);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 60;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Bookbtn
            // 
            Bookbtn.Location = new Point(15, 304);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(75, 23);
            Bookbtn.TabIndex = 59;
            Bookbtn.Text = "Book";
            Bookbtn.UseVisualStyleBackColor = true;
            Bookbtn.Click += Addbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(265, 104);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(222, 23);
            dtpCheckOut.TabIndex = 68;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(9, 104);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(224, 23);
            dtpCheckIn.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(254, 86);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 66;
            label8.Text = "Checkout";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(9, 86);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 65;
            label7.Text = "Check in";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(searchbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Bookbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(cmbRoomType);
            Controls.Add(txtRoomNumber);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBookingID);
            Controls.Add(label6);
            Controls.Add(txtGuestName);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            Load += Booking_Load;
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
        private Label label1;
        private TextBox txtBookingID;
        private Label label6;
        private TextBox txtGuestName;
        private Label label3;
        private ComboBox cmbRoomType;
        private TextBox txtRoomNumber;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button searchbtn;
        private Button Deletebtn;
        private Button Updatebtn;
        private Button Bookbtn;
        private PictureBox pictureBox1;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private Label label8;
        private Label label7;
    }
}