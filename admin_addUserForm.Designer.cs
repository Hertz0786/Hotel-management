namespace Hotel_Management
{
    partial class admin_addUserForm
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
            panel1 = new Panel();
            addUser_updateBtn = new Button();
            addUser_deleteBtn = new Button();
            addUser_clearname = new Button();
            addUser_addBtn = new Button();
            addUser_status = new ComboBox();
            label4 = new Label();
            addUser_role = new ComboBox();
            label3 = new Label();
            addUser_password = new TextBox();
            label2 = new Label();
            addUser_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addUser_updateBtn);
            panel1.Controls.Add(addUser_deleteBtn);
            panel1.Controls.Add(addUser_clearname);
            panel1.Controls.Add(addUser_addBtn);
            panel1.Controls.Add(addUser_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUser_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUser_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUser_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 817);
            panel1.TabIndex = 0;
            // 
            // addUser_updateBtn
            // 
            addUser_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_updateBtn.FlatAppearance.BorderSize = 0;
            addUser_updateBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_updateBtn.ForeColor = Color.White;
            addUser_updateBtn.Location = new Point(49, 547);
            addUser_updateBtn.Name = "addUser_updateBtn";
            addUser_updateBtn.Size = new Size(231, 56);
            addUser_updateBtn.TabIndex = 11;
            addUser_updateBtn.Text = "Update";
            addUser_updateBtn.UseVisualStyleBackColor = false;
            addUser_updateBtn.Click += addUser_updateBtn_Click;
            // 
            // addUser_deleteBtn
            // 
            addUser_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_deleteBtn.FlatAppearance.BorderSize = 0;
            addUser_deleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_deleteBtn.ForeColor = Color.White;
            addUser_deleteBtn.Location = new Point(49, 627);
            addUser_deleteBtn.Name = "addUser_deleteBtn";
            addUser_deleteBtn.Size = new Size(231, 56);
            addUser_deleteBtn.TabIndex = 10;
            addUser_deleteBtn.Text = "Delete";
            addUser_deleteBtn.UseVisualStyleBackColor = false;
            addUser_deleteBtn.Click += addUser_deleteBtn_Click;
            // 
            // addUser_clearname
            // 
            addUser_clearname.BackColor = Color.FromArgb(3, 14, 28);
            addUser_clearname.FlatAppearance.BorderSize = 0;
            addUser_clearname.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_clearname.ForeColor = Color.White;
            addUser_clearname.Location = new Point(49, 702);
            addUser_clearname.Name = "addUser_clearname";
            addUser_clearname.Size = new Size(231, 56);
            addUser_clearname.TabIndex = 9;
            addUser_clearname.Text = "Clear";
            addUser_clearname.UseVisualStyleBackColor = false;
            addUser_clearname.Click += addUser_clearname_Click;
            // 
            // addUser_addBtn
            // 
            addUser_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_addBtn.FlatAppearance.BorderSize = 0;
            addUser_addBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_addBtn.ForeColor = Color.White;
            addUser_addBtn.Location = new Point(49, 468);
            addUser_addBtn.Name = "addUser_addBtn";
            addUser_addBtn.Size = new Size(231, 56);
            addUser_addBtn.TabIndex = 8;
            addUser_addBtn.Text = "Add";
            addUser_addBtn.UseVisualStyleBackColor = false;
            addUser_addBtn.Click += addUser_addBtn_Click;
            // 
            // addUser_status
            // 
            addUser_status.FormattingEnabled = true;
            addUser_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addUser_status.Location = new Point(25, 391);
            addUser_status.Name = "addUser_status";
            addUser_status.Size = new Size(267, 23);
            addUser_status.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 341);
            label4.Name = "label4";
            label4.Size = new Size(73, 30);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // addUser_role
            // 
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "Admin", "Staff" });
            addUser_role.Location = new Point(25, 291);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(267, 23);
            addUser_role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 241);
            label3.Name = "label3";
            label3.Size = new Size(56, 30);
            label3.TabIndex = 4;
            label3.Text = "Role";
            label3.Click += label3_Click;
            // 
            // addUser_password
            // 
            addUser_password.Location = new Point(25, 185);
            addUser_password.Name = "addUser_password";
            addUser_password.Size = new Size(267, 23);
            addUser_password.TabIndex = 3;
            addUser_password.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 139);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUser_username
            // 
            addUser_username.Location = new Point(25, 88);
            addUser_username.Name = "addUser_username";
            addUser_username.Size = new Size(267, 23);
            addUser_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(346, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 817);
            panel2.TabIndex = 1;
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
            dataGridView1.Location = new Point(13, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(571, 741);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 9);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 1;
            label5.Text = "User's Data";
            // 
            // admin_addUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 841);
            Controls.Add(panel2);
            Controls.Add(panel1);
            //FormBorderStyle = FormBorderStyle.None;
            Name = "admin_addUserForm";
            Text = "admin_addUserForm";
            Load += admin_addUserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox addUser_role;
        private Label label3;
        private TextBox addUser_password;
        private Label label2;
        private TextBox addUser_username;
        private Button addUser_updateBtn;
        private Button addUser_deleteBtn;
        private Button addUser_clearname;
        private Button addUser_addBtn;
        private ComboBox addUser_status;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}