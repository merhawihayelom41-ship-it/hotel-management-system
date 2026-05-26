namespace HMSPROJECT
{
    partial class DailyReport
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
            viewbtn = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
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
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 13);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "DAILY REPORTS";
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.FromArgb(0, 192, 0);
            viewbtn.FlatStyle = FlatStyle.Flat;
            viewbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewbtn.ForeColor = Color.White;
            viewbtn.Location = new Point(12, 63);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 23);
            viewbtn.TabIndex = 3;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 193);
            dataGridView1.TabIndex = 5;
            // 
            // DailyReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(viewbtn);
            Controls.Add(panel2);
            Name = "DailyReport";
            Text = "DailyReport";
            Load += DailyReport_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button viewbtn;
        private Button button1;
        private DataGridView dataGridView1;
    }
}