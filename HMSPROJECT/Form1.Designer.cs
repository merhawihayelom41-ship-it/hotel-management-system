namespace HMSPROJECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            chkShowPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Yellow;
            loginbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.Black;
            loginbtn.Location = new Point(172, 250);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(75, 27);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 150);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(139, 182);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 130);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(124, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 9);
            label3.Name = "label3";
            label3.Size = new Size(229, 20);
            label3.TabIndex = 1;
            label3.Text = "HOTEL MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logicon;
            pictureBox1.Location = new Point(19, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.White;
            chkShowPassword.Location = new Point(249, 209);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(104, 19);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "showpassword";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(365, 286);
            Controls.Add(chkShowPassword);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private CheckBox chkShowPassword;
    }
}
