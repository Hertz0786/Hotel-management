namespace Hotel_Management
{
    partial class RegisterForm
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
            register_signinbtn = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            close = new Label();
            register_signupbtn = new Button();
            register_username = new TextBox();
            register_password = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            register_cfpassword = new TextBox();
            register_showPass = new CheckBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 12, 28);
            panel1.Controls.Add(register_signinbtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 450);
            panel1.TabIndex = 11;
            // 
            // register_signinbtn
            // 
            register_signinbtn.BackColor = Color.FromArgb(3, 12, 28);
            register_signinbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signinbtn.ForeColor = Color.White;
            register_signinbtn.Location = new Point(89, 381);
            register_signinbtn.Name = "register_signinbtn";
            register_signinbtn.Size = new Size(215, 43);
            register_signinbtn.TabIndex = 0;
            register_signinbtn.Text = "Sign in";
            register_signinbtn.UseVisualStyleBackColor = false;
            register_signinbtn.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(83, 321);
            label8.Name = "label8";
            label8.Size = new Size(236, 32);
            label8.TabIndex = 9;
            label8.Text = "Sign in your account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1668966;
            pictureBox1.Location = new Point(105, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(780, 0);
            close.Name = "close";
            close.Size = new Size(20, 21);
            close.TabIndex = 5;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // register_signupbtn
            // 
            register_signupbtn.BackColor = Color.FromArgb(3, 12, 28);
            register_signupbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signupbtn.ForeColor = Color.White;
            register_signupbtn.Location = new Point(523, 381);
            register_signupbtn.Name = "register_signupbtn";
            register_signupbtn.Size = new Size(176, 43);
            register_signupbtn.TabIndex = 4;
            register_signupbtn.Text = "Sign up";
            register_signupbtn.UseVisualStyleBackColor = false;
            register_signupbtn.Click += register_signupbtn_Click;
            // 
            // register_username
            // 
            register_username.Location = new Point(446, 164);
            register_username.Name = "register_username";
            register_username.Size = new Size(317, 23);
            register_username.TabIndex = 0;
            // 
            // register_password
            // 
            register_password.Location = new Point(446, 236);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(317, 23);
            register_password.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(446, 138);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 14;
            label4.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 206);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(446, 61);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 12;
            label2.Text = "REGISTER";
            // 
            // register_cfpassword
            // 
            register_cfpassword.Location = new Point(446, 304);
            register_cfpassword.Name = "register_cfpassword";
            register_cfpassword.PasswordChar = '*';
            register_cfpassword.Size = new Size(317, 23);
            register_cfpassword.TabIndex = 2;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Location = new Point(446, 334);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(108, 19);
            register_showPass.TabIndex = 3;
            register_showPass.Text = "Show password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showpass_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(446, 281);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 20;
            label6.Text = "Confirm password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(register_cfpassword);
            Controls.Add(panel1);
            Controls.Add(close);
            Controls.Add(register_showPass);
            Controls.Add(register_signupbtn);
            Controls.Add(register_username);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button register_signinbtn;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label5;
        private Label close;
        private Button register_signupbtn;
        private TextBox register_username;
        private TextBox register_password;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox register_cfpassword;
        private CheckBox register_showPass;
        private Label label6;
    }
}