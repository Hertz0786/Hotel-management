namespace Hotel_Management
{
    partial class admin_room_Form
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            rooms_importBtn = new Button();
            rooms_clearBtn = new Button();
            rooms_deleteBtn = new Button();
            rooms_updateBtn = new Button();
            rooms_addBtn = new Button();
            panel3 = new Panel();
            rooms_picture = new PictureBox();
            rooms_status = new ComboBox();
            rooms_type = new ComboBox();
            rooms_roomName = new TextBox();
            rooms_price = new TextBox();
            rooms_roomID = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 496);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 17);
            label5.Name = "label5";
            label5.Size = new Size(122, 30);
            label5.TabIndex = 2;
            label5.Text = "Room'Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(893, 414);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_importBtn);
            panel2.Controls.Add(rooms_clearBtn);
            panel2.Controls.Add(rooms_deleteBtn);
            panel2.Controls.Add(rooms_updateBtn);
            panel2.Controls.Add(rooms_addBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(rooms_roomName);
            panel2.Controls.Add(rooms_price);
            panel2.Controls.Add(rooms_roomID);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 542);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 287);
            panel2.TabIndex = 1;
            // 
            // rooms_importBtn
            // 
            rooms_importBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_importBtn.FlatAppearance.BorderSize = 0;
            rooms_importBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_importBtn.ForeColor = Color.White;
            rooms_importBtn.Location = new Point(828, 124);
            rooms_importBtn.Name = "rooms_importBtn";
            rooms_importBtn.Size = new Size(80, 36);
            rooms_importBtn.TabIndex = 20;
            rooms_importBtn.Text = "Import";
            rooms_importBtn.UseVisualStyleBackColor = false;
            rooms_importBtn.Click += rooms_importBtn_Click;
            // 
            // rooms_clearBtn
            // 
            rooms_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_clearBtn.FlatAppearance.BorderSize = 0;
            rooms_clearBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_clearBtn.ForeColor = Color.White;
            rooms_clearBtn.Location = new Point(686, 205);
            rooms_clearBtn.Name = "rooms_clearBtn";
            rooms_clearBtn.Size = new Size(186, 56);
            rooms_clearBtn.TabIndex = 19;
            rooms_clearBtn.Text = "Clear";
            rooms_clearBtn.UseVisualStyleBackColor = false;
            rooms_clearBtn.Click += rooms_clearBtn_Click;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_deleteBtn.ForeColor = Color.White;
            rooms_deleteBtn.Location = new Point(476, 205);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(186, 56);
            rooms_deleteBtn.TabIndex = 18;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click;
            // 
            // rooms_updateBtn
            // 
            rooms_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_updateBtn.FlatAppearance.BorderSize = 0;
            rooms_updateBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_updateBtn.ForeColor = Color.White;
            rooms_updateBtn.Location = new Point(250, 205);
            rooms_updateBtn.Name = "rooms_updateBtn";
            rooms_updateBtn.Size = new Size(186, 56);
            rooms_updateBtn.TabIndex = 17;
            rooms_updateBtn.Text = "Update";
            rooms_updateBtn.UseVisualStyleBackColor = false;
            rooms_updateBtn.Click += rooms_updateBtn_Click;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(24, 205);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(186, 56);
            rooms_addBtn.TabIndex = 16;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(rooms_picture);
            panel3.Location = new Point(828, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(80, 100);
            panel3.TabIndex = 15;
            // 
            // rooms_picture
            // 
            rooms_picture.BackColor = Color.Gray;
            rooms_picture.Location = new Point(0, 0);
            rooms_picture.Name = "rooms_picture";
            rooms_picture.Size = new Size(80, 100);
            rooms_picture.SizeMode = PictureBoxSizeMode.Zoom;
            rooms_picture.TabIndex = 0;
            rooms_picture.TabStop = false;
            rooms_picture.Click += pictureBox1_Click;
            // 
            // rooms_status
            // 
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "Active", "Inactive", "Occupied" });
            rooms_status.Location = new Point(562, 109);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(133, 23);
            rooms_status.TabIndex = 14;
            // 
            // rooms_type
            // 
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single room", "Double room" });
            rooms_type.Location = new Point(125, 75);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(184, 23);
            rooms_type.TabIndex = 12;
            // 
            // rooms_roomName
            // 
            rooms_roomName.Location = new Point(125, 122);
            rooms_roomName.Name = "rooms_roomName";
            rooms_roomName.Size = new Size(184, 23);
            rooms_roomName.TabIndex = 11;
            // 
            // rooms_price
            // 
            rooms_price.Location = new Point(562, 59);
            rooms_price.Name = "rooms_price";
            rooms_price.Size = new Size(133, 23);
            rooms_price.TabIndex = 10;
            // 
            // rooms_roomID
            // 
            rooms_roomID.Location = new Point(125, 28);
            rooms_roomID.Name = "rooms_roomID";
            rooms_roomID.Size = new Size(109, 23);
            rooms_roomID.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(461, 111);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 8;
            label6.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(461, 57);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 7;
            label4.Text = "Pride ($)";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 124);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 6;
            label2.Text = "Room Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 77);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 5;
            label1.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 26);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "Room ID";
            // 
            // admin_room_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 841);
            Controls.Add(panel2);
            Controls.Add(panel1);
            //FormBorderStyle = FormBorderStyle.None;
            Name = "admin_room_Form";
            Text = "admin_room_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rooms_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox rooms_roomName;
        private TextBox rooms_price;
        private TextBox rooms_roomID;
        private ComboBox rooms_status;
        private ComboBox rooms_type;
        private Panel panel3;
        private PictureBox rooms_picture;
        private Button rooms_importBtn;
        private Button rooms_clearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
    }
}