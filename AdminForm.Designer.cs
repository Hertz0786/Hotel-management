namespace Hotel_Management
{
    partial class AdminForm
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
            close = new Label();
            label2 = new Label();
            panel2 = new Panel();
            customers_btn = new Button();
            rooms_btn = new Button();
            addUser_btn = new Button();
            dashboard_btn = new Button();
            logout_btn = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel9 = new Panel();
            panel8 = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 12, 28);
            panel1.Controls.Add(close);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 47);
            panel1.TabIndex = 1;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(1260, 0);
            close.Name = "close";
            close.Size = new Size(20, 21);
            close.TabIndex = 11;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(3, 12, 18);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(315, 32);
            label2.TabIndex = 11;
            label2.Text = "Hotel Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 110, 138);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(rooms_btn);
            panel2.Controls.Add(addUser_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 841);
            panel2.TabIndex = 2;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.FromArgb(52, 110, 138);
            customers_btn.Cursor = Cursors.Hand;
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 12, 28);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 12, 28);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(70, 549);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(197, 59);
            customers_btn.TabIndex = 4;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += button2_Click;
            // 
            // rooms_btn
            // 
            rooms_btn.BackColor = Color.FromArgb(52, 110, 138);
            rooms_btn.Cursor = Cursors.Hand;
            rooms_btn.FlatAppearance.BorderSize = 0;
            rooms_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 12, 28);
            rooms_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 12, 28);
            rooms_btn.FlatStyle = FlatStyle.Flat;
            rooms_btn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_btn.ForeColor = Color.White;
            rooms_btn.Location = new Point(70, 462);
            rooms_btn.Name = "rooms_btn";
            rooms_btn.Size = new Size(197, 59);
            rooms_btn.TabIndex = 5;
            rooms_btn.Text = "Rooms";
            rooms_btn.UseVisualStyleBackColor = false;
            // 
            // addUser_btn
            // 
            addUser_btn.BackColor = Color.FromArgb(52, 110, 138);
            addUser_btn.Cursor = Cursors.Hand;
            addUser_btn.FlatAppearance.BorderSize = 0;
            addUser_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 12, 28);
            addUser_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 12, 28);
            addUser_btn.FlatStyle = FlatStyle.Flat;
            addUser_btn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_btn.ForeColor = Color.White;
            addUser_btn.Location = new Point(70, 381);
            addUser_btn.Name = "addUser_btn";
            addUser_btn.Size = new Size(197, 59);
            addUser_btn.TabIndex = 6;
            addUser_btn.Text = "Add User";
            addUser_btn.UseVisualStyleBackColor = false;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(52, 110, 138);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 12, 28);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 12, 28);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(69, 298);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(197, 59);
            dashboard_btn.TabIndex = 3;
            dashboard_btn.Text = "DashBoard";
            dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(52, 110, 138);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.WhiteSmoke;
            logout_btn.Location = new Point(52, 723);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(215, 43);
            logout_btn.TabIndex = 13;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += register_signinbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(52, 110, 138);
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 183);
            label5.Name = "label5";
            label5.Size = new Size(181, 32);
            label5.TabIndex = 10;
            label5.Text = "Welcome, User";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1668966;
            pictureBox1.Location = new Point(69, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel8);
            panel9.Controls.Add(panel3);
            panel9.Location = new Point(325, 47);
            panel9.Name = "panel9";
            panel9.Size = new Size(955, 841);
            panel9.TabIndex = 6;
            panel9.Paint += panel9_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(20, 282);
            panel8.Name = "panel8";
            panel8.Size = new Size(914, 547);
            panel8.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(20, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 215);
            panel3.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 110, 138);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(707, 27);
            panel7.Name = "panel7";
            panel7.Size = new Size(190, 144);
            panel7.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(146, 20);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 11;
            label7.Text = "$0.0";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.free_cash_1013_517930;
            pictureBox4.Location = new Point(13, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 102);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 10;
            label8.Text = "Total Staff";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 110, 138);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(479, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 144);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 20);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 9;
            label1.Text = "$0.0";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._4470504;
            pictureBox3.Location = new Point(14, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 102);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 8;
            label6.Text = "Total Staff";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 110, 138);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(256, 27);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 144);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(159, 20);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 7;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._71556_200;
            pictureBox2.Location = new Point(19, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 102);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 6;
            label4.Text = "Total Staff";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 110, 138);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(30, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 144);
            panel4.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(159, 20);
            label9.Name = "label9";
            label9.Size = new Size(19, 21);
            label9.TabIndex = 5;
            label9.Text = "0";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(17, 102);
            label10.Name = "label10";
            label10.Size = new Size(84, 21);
            label10.TabIndex = 4;
            label10.Text = "Total Staff";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._1144760;
            pictureBox5.Location = new Point(17, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 68);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 888);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Button logout_btn;
        private Label close;
        private Button dashboard_btn;
        private Button customers_btn;
        private Button rooms_btn;
        private Button addUser_btn;
        private Panel panel9;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel8;
        private Panel panel3;
        private Panel panel7;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label8;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel6;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
    }
}