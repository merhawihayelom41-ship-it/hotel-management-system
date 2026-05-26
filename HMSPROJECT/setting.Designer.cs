namespace HMSPROJECT
{
    partial class setting
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
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            Updatebtn = new Button();
            pictureBox1 = new PictureBox();
            viewsecurityBtn = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 20;
            label1.Text = "SETTING";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(427, 169);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 29;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(427, 102);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 27;
            label2.Text = "Username";
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(427, 265);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 38;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eee;
            pictureBox1.Location = new Point(527, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // viewsecurityBtn
            // 
            viewsecurityBtn.Location = new Point(12, 67);
            viewsecurityBtn.Name = "viewsecurityBtn";
            viewsecurityBtn.Size = new Size(120, 23);
            viewsecurityBtn.TabIndex = 40;
            viewsecurityBtn.Text = "view security";
            viewsecurityBtn.UseVisualStyleBackColor = true;
            viewsecurityBtn.Click += viewsecurityBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 192);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(603, 339);
            Controls.Add(dataGridView1);
            Controls.Add(viewsecurityBtn);
            Controls.Add(pictureBox1);
            Controls.Add(Updatebtn);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "setting";
            Text = "setting";
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
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button Updatebtn;
        private PictureBox pictureBox1;
        private Button viewsecurityBtn;
        private DataGridView dataGridView1;
    }
}