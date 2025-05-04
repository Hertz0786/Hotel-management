namespace Hotel_Management
{
    partial class staffMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel3 = new Panel();
            rooms_addBtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            label15 = new Label();
            label14 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel1.TabIndex = 2;
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
            panel2.TabIndex = 3;
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
            rooms_btn.Text = "Available Rooms";
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
            addUser_btn.Text = "Book Room";
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
            logout_btn.Click += logout_btn_Click;
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
            // panel3
            // 
            panel3.Controls.Add(rooms_addBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(345, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 472);
            panel3.TabIndex = 4;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(16, 404);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(186, 56);
            rooms_addBtn.TabIndex = 17;
            rooms_addBtn.Text = "Check Room";
            rooms_addBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 4;
            label1.Text = "Available Rooms";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(16, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(570, 341);
            dataGridView1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(971, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 803);
            panel4.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(150, 531);
            label15.Name = "label15";
            label15.Size = new Size(45, 21);
            label15.TabIndex = 26;
            label15.Text = "0.00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(27, 532);
            label14.Name = "label14";
            label14.Size = new Size(103, 20);
            label14.TabIndex = 25;
            label14.Text = "Total Price($) :";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(3, 14, 28);
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(27, 661);
            button4.Name = "button4";
            button4.Size = new Size(255, 56);
            button4.TabIndex = 24;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(3, 14, 28);
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(27, 439);
            button3.Name = "button3";
            button3.Size = new Size(255, 56);
            button3.TabIndex = 23;
            button3.Text = "Schedule Now";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 14, 28);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(27, 732);
            button2.Name = "button2";
            button2.Size = new Size(255, 56);
            button2.TabIndex = 22;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(7, 375);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(188, 23);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(7, 308);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(7, 272);
            label13.Name = "label13";
            label13.Size = new Size(102, 20);
            label13.TabIndex = 19;
            label13.Text = "From Schedule";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 345);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 18;
            label12.Text = "To Schedule";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 14, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 590);
            button1.Name = "button1";
            button1.Size = new Size(255, 56);
            button1.TabIndex = 17;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 199);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 12;
            label8.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(126, 199);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 11;
            label9.Text = "__________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(126, 142);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 10;
            label10.Text = "__________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(27, 142);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 9;
            label11.Text = "Room Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 81);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 8;
            label7.Text = "Room Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(126, 81);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 7;
            label6.Text = "__________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 31);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "__________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 31);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Room ID:";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(361, 596);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(570, 265);
            dataGridView2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Location = new Point(345, 570);
            panel5.Name = "panel5";
            panel5.Size = new Size(607, 306);
            panel5.TabIndex = 4;
            // 
            // staffMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 888);
            Controls.Add(dataGridView2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffMainForm";
            Text = "staffMainForm";
            Load += staffMainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private Panel panel2;
        private Button customers_btn;
        private Button rooms_btn;
        private Button addUser_btn;
        private Button dashboard_btn;
        private Button logout_btn;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel5;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button rooms_addBtn;
        private Button button3;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private Label label12;
        private Button button1;
        private Button button4;
        private Label label15;
        private Label label14;
    }
}