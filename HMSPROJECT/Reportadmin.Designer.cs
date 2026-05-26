namespace HMSPROJECT
{
    partial class Reportadmin
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            viewbtn = new Button();
            Deletebtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 46);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 46);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 13);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "TOTAL REPORTS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 206);
            dataGridView1.TabIndex = 1;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.FromArgb(0, 192, 0);
            viewbtn.FlatStyle = FlatStyle.Flat;
            viewbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewbtn.ForeColor = Color.White;
            viewbtn.Location = new Point(21, 62);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 23);
            viewbtn.TabIndex = 2;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(21, 300);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 23);
            Deletebtn.TabIndex = 36;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Reportadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(Deletebtn);
            Controls.Add(viewbtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Reportadmin";
            Text = "Reportadmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button viewbtn;
        private Button Deletebtn;
    }
}