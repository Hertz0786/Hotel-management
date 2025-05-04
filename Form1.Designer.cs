namespace Hotel_Management
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
            close = new Label();
            panel1 = new Panel();
            login_registerbtn = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            login_password = new TextBox();
            login_username = new TextBox();
            login_btn = new Button();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(780, 0);
            close.Name = "close";
            close.Size = new Size(20, 21);
            close.TabIndex = 4;
            close.Text = "X";
            close.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 12, 28);
            panel1.Controls.Add(login_registerbtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 450);
            panel1.TabIndex = 1;
            // 
            // login_registerbtn
            // 
            login_registerbtn.BackColor = Color.FromArgb(3, 12, 28);
            login_registerbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerbtn.ForeColor = Color.White;
            login_registerbtn.Location = new Point(89, 381);
            login_registerbtn.Name = "login_registerbtn";
            login_registerbtn.Size = new Size(215, 43);
            login_registerbtn.TabIndex = 0;
            login_registerbtn.Text = "Register";
            login_registerbtn.UseVisualStyleBackColor = false;
            login_registerbtn.Click += login_registerbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(83, 321);
            label8.Name = "label8";
            label8.Size = new Size(234, 32);
            label8.TabIndex = 9;
            label8.Text = " Create new account";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._1668966;
            pictureBox1.InitialImage = Properties.Resources.images;
            pictureBox1.Location = new Point(105, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(3, 12, 28);
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(89, 206);
            label5.Name = "label5";
            label5.Size = new Size(228, 32);
            label5.TabIndex = 0;
            label5.Text = "Hotel Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(446, 61);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 2;
            label2.Text = "WELCOME";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 206);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(446, 138);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "UserName";
            // 
            // login_password
            // 
            login_password.Location = new Point(446, 236);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(317, 23);
            login_password.TabIndex = 1;
            // 
            // login_username
            // 
            login_username.Location = new Point(446, 164);
            login_username.Name = "login_username";
            login_username.Size = new Size(317, 23);
            login_username.TabIndex = 0;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(3, 12, 28);
            login_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(528, 321);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(176, 43);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(446, 279);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(108, 19);
            login_showPass.TabIndex = 2;
            login_showPass.Text = "Show password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_username);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label close;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox login_password;
        private TextBox login_username;
        private Label label5;
        private Button login_btn;
        private PictureBox pictureBox1;
        private Button login_registerbtn;
        private Label label8;
        private CheckBox login_showPass;
    }
}
