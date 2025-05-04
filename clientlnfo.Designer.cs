namespace Hotel_Management
{
    partial class clientlnfo
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
            label1 = new Label();
            client_bookID = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            client_fullName = new TextBox();
            panel1 = new Panel();
            client_gender = new ComboBox();
            client_clearBtn = new Button();
            client_bookBtn = new Button();
            client_email = new TextBox();
            client_contact = new TextBox();
            client_address = new TextBox();
            panel2 = new Panel();
            label9 = new Label();
            close = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 59);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Book ID:";
            // 
            // client_bookID
            // 
            client_bookID.AutoSize = true;
            client_bookID.BackColor = Color.White;
            client_bookID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_bookID.Location = new Point(187, 59);
            client_bookID.Name = "client_bookID";
            client_bookID.Size = new Size(72, 21);
            client_bookID.TabIndex = 1;
            client_bookID.Text = "Book ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 179);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(430, 108);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 255);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 4;
            label5.Text = "Contact Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 185);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 5;
            label6.Text = "Email Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(88, 121);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 6;
            label7.Text = "Full Name:";
            // 
            // client_fullName
            // 
            client_fullName.Location = new Point(187, 119);
            client_fullName.Name = "client_fullName";
            client_fullName.Size = new Size(180, 23);
            client_fullName.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(client_gender);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(client_clearBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(client_bookBtn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(client_fullName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(client_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(client_contact);
            panel1.Controls.Add(client_address);
            panel1.Controls.Add(client_bookID);
            panel1.Location = new Point(24, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 439);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // client_gender
            // 
            client_gender.FormattingEnabled = true;
            client_gender.Items.AddRange(new object[] { "Male", "Female" });
            client_gender.Location = new Point(505, 110);
            client_gender.Name = "client_gender";
            client_gender.Size = new Size(191, 23);
            client_gender.TabIndex = 26;
            // 
            // client_clearBtn
            // 
            client_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            client_clearBtn.FlatAppearance.BorderSize = 0;
            client_clearBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_clearBtn.ForeColor = Color.White;
            client_clearBtn.Location = new Point(466, 349);
            client_clearBtn.Name = "client_clearBtn";
            client_clearBtn.Size = new Size(255, 56);
            client_clearBtn.TabIndex = 25;
            client_clearBtn.Text = "CLear";
            client_clearBtn.UseVisualStyleBackColor = false;
            client_clearBtn.Click += client_clearBtn_Click;
            // 
            // client_bookBtn
            // 
            client_bookBtn.BackColor = Color.FromArgb(3, 14, 28);
            client_bookBtn.FlatAppearance.BorderSize = 0;
            client_bookBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_bookBtn.ForeColor = Color.White;
            client_bookBtn.Location = new Point(73, 349);
            client_bookBtn.Name = "client_bookBtn";
            client_bookBtn.Size = new Size(255, 56);
            client_bookBtn.TabIndex = 24;
            client_bookBtn.Text = "Book Now";
            client_bookBtn.UseVisualStyleBackColor = false;
            client_bookBtn.Click += client_bookBtn_Click;
            // 
            // client_email
            // 
            client_email.Location = new Point(187, 183);
            client_email.Name = "client_email";
            client_email.Size = new Size(180, 23);
            client_email.TabIndex = 10;
            // 
            // client_contact
            // 
            client_contact.Location = new Point(187, 253);
            client_contact.Name = "client_contact";
            client_contact.Size = new Size(180, 23);
            client_contact.TabIndex = 9;
            // 
            // client_address
            // 
            client_address.Location = new Point(505, 181);
            client_address.Multiline = true;
            client_address.Name = "client_address";
            client_address.Size = new Size(188, 93);
            client_address.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 12, 28);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(close);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 47);
            panel2.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(815, 9);
            label9.Name = "label9";
            label9.Size = new Size(20, 21);
            label9.TabIndex = 12;
            label9.Text = "X";
            label9.Click += label9_Click;
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
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(3, 12, 18);
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(249, 25);
            label8.TabIndex = 11;
            label8.Text = "Hotel Management System";
            // 
            // clientlnfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientlnfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clientlnfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label client_bookID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox client_fullName;
        private Panel panel1;
        private TextBox client_email;
        private TextBox client_contact;
        private TextBox client_address;
        private Button client_clearBtn;
        private Button client_bookBtn;
        private ComboBox client_gender;
        private Panel panel2;
        private Label close;
        private Label label8;
        private Label label9;
    }
}