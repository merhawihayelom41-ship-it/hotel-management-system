namespace HMSPROJECT
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtBillingID = new TextBox();
            label6 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cmbStatus = new ComboBox();
            txtPrice = new TextBox();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            searchbtn = new Button();
            Deletebtn = new Button();
            Updatebtn = new Button();
            savebtn = new Button();
            pictureBox1 = new PictureBox();
            printbtn = new Button();
            rtbReceipt = new RichTextBox();
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
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 21;
            label2.Text = " MANAGE BILLING";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(185, 38);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 51;
            label3.Text = "Last name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(185, 56);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(90, 23);
            txtLastName.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 49;
            label1.Text = "First name";
            // 
            // txtBillingID
            // 
            txtBillingID.Location = new Point(8, 56);
            txtBillingID.Name = "txtBillingID";
            txtBillingID.Size = new Size(60, 23);
            txtBillingID.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 38);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 47;
            label6.Text = "Billing ID";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(79, 56);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(90, 23);
            txtFirstName.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(296, 38);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 55;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(381, 38);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 54;
            label4.Text = "Price(Birr)";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active ", "Inactive", "Occupied" });
            cmbStatus.Location = new Point(296, 56);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(69, 23);
            cmbStatus.TabIndex = 53;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(381, 56);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(66, 23);
            txtPrice.TabIndex = 52;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(391, 98);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(426, 304);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 68;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(345, 304);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 67;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(232, 304);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 66;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(114, 304);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 65;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(14, 304);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 64;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(405, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // printbtn
            // 
            printbtn.BackColor = Color.FromArgb(128, 255, 128);
            printbtn.Location = new Point(480, 56);
            printbtn.Name = "printbtn";
            printbtn.Size = new Size(75, 23);
            printbtn.TabIndex = 70;
            printbtn.Text = "Print";
            printbtn.UseVisualStyleBackColor = false;
            printbtn.Click += printbtn_Click;
            // 
            // rtbReceipt
            // 
            rtbReceipt.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbReceipt.Location = new Point(8, 202);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Size = new Size(391, 96);
            rtbReceipt.TabIndex = 71;
            rtbReceipt.Text = "";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(rtbReceipt);
            Controls.Add(printbtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(searchbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(savebtn);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtBillingID);
            Controls.Add(label6);
            Controls.Add(txtFirstName);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
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
        private Label label3;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtBillingID;
        private Label label6;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private ComboBox cmbStatus;
        private TextBox txtPrice;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button searchbtn;
        private Button Deletebtn;
        private Button Updatebtn;
        private Button savebtn;
        private PictureBox pictureBox1;
        private Button printbtn;
        private RichTextBox rtbReceipt;
    }
}