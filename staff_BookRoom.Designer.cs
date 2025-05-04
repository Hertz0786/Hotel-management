namespace Hotel_Management
{
    partial class staff_BookRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView2 = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            bookRoom_regPrice = new Label();
            bookRoom_total = new Label();
            label14 = new Label();
            bookRoom_printBtn = new Button();
            bookRoom_scheduleBtn = new Button();
            bookRoom_clearBtn = new Button();
            bookRoom_to = new DateTimePicker();
            bookRoom_from = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            bookRoom_bookBtn = new Button();
            label8 = new Label();
            bookRoom_status = new Label();
            bookRoom_roomName = new Label();
            label11 = new Label();
            label7 = new Label();
            bookRoom_roomType = new Label();
            bookRoom_roomID = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            bookRoom_imageView = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookRoom_imageView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(16, 16);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(570, 265);
            dataGridView2.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(bookRoom_regPrice);
            panel4.Controls.Add(bookRoom_total);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(bookRoom_printBtn);
            panel4.Controls.Add(bookRoom_scheduleBtn);
            panel4.Controls.Add(bookRoom_clearBtn);
            panel4.Controls.Add(bookRoom_to);
            panel4.Controls.Add(bookRoom_from);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(bookRoom_bookBtn);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(bookRoom_status);
            panel4.Controls.Add(bookRoom_roomName);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(bookRoom_roomType);
            panel4.Controls.Add(bookRoom_roomID);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(642, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 803);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 230);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 28;
            label2.Text = "Regular Price($):";
            // 
            // bookRoom_regPrice
            // 
            bookRoom_regPrice.AutoSize = true;
            bookRoom_regPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bookRoom_regPrice.Location = new Point(139, 230);
            bookRoom_regPrice.Name = "bookRoom_regPrice";
            bookRoom_regPrice.Size = new Size(36, 20);
            bookRoom_regPrice.TabIndex = 27;
            bookRoom_regPrice.Text = "0.00";
            // 
            // bookRoom_total
            // 
            bookRoom_total.AutoSize = true;
            bookRoom_total.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_total.Location = new Point(150, 531);
            bookRoom_total.Name = "bookRoom_total";
            bookRoom_total.Size = new Size(45, 21);
            bookRoom_total.TabIndex = 26;
            bookRoom_total.Text = "0.00";
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
            // bookRoom_printBtn
            // 
            bookRoom_printBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_printBtn.FlatAppearance.BorderSize = 0;
            bookRoom_printBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_printBtn.ForeColor = Color.White;
            bookRoom_printBtn.Location = new Point(27, 661);
            bookRoom_printBtn.Name = "bookRoom_printBtn";
            bookRoom_printBtn.Size = new Size(255, 56);
            bookRoom_printBtn.TabIndex = 24;
            bookRoom_printBtn.Text = "Print";
            bookRoom_printBtn.UseVisualStyleBackColor = false;
            // 
            // bookRoom_scheduleBtn
            // 
            bookRoom_scheduleBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_scheduleBtn.FlatAppearance.BorderSize = 0;
            bookRoom_scheduleBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_scheduleBtn.ForeColor = Color.White;
            bookRoom_scheduleBtn.Location = new Point(27, 439);
            bookRoom_scheduleBtn.Name = "bookRoom_scheduleBtn";
            bookRoom_scheduleBtn.Size = new Size(255, 56);
            bookRoom_scheduleBtn.TabIndex = 23;
            bookRoom_scheduleBtn.Text = "Schedule Now";
            bookRoom_scheduleBtn.UseVisualStyleBackColor = false;
            bookRoom_scheduleBtn.Click += bookRoom_scheduleBtn_Click;
            // 
            // bookRoom_clearBtn
            // 
            bookRoom_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_clearBtn.FlatAppearance.BorderSize = 0;
            bookRoom_clearBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_clearBtn.ForeColor = Color.White;
            bookRoom_clearBtn.Location = new Point(27, 732);
            bookRoom_clearBtn.Name = "bookRoom_clearBtn";
            bookRoom_clearBtn.Size = new Size(255, 56);
            bookRoom_clearBtn.TabIndex = 22;
            bookRoom_clearBtn.Text = "Clear";
            bookRoom_clearBtn.UseVisualStyleBackColor = false;
            bookRoom_clearBtn.Click += bookRoom_clearBtn_Click;
            // 
            // bookRoom_to
            // 
            bookRoom_to.Location = new Point(7, 375);
            bookRoom_to.Name = "bookRoom_to";
            bookRoom_to.Size = new Size(188, 23);
            bookRoom_to.TabIndex = 21;
            // 
            // bookRoom_from
            // 
            bookRoom_from.Location = new Point(7, 308);
            bookRoom_from.Name = "bookRoom_from";
            bookRoom_from.Size = new Size(188, 23);
            bookRoom_from.TabIndex = 20;
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
            // bookRoom_bookBtn
            // 
            bookRoom_bookBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_bookBtn.FlatAppearance.BorderSize = 0;
            bookRoom_bookBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_bookBtn.ForeColor = Color.White;
            bookRoom_bookBtn.Location = new Point(27, 590);
            bookRoom_bookBtn.Name = "bookRoom_bookBtn";
            bookRoom_bookBtn.Size = new Size(255, 56);
            bookRoom_bookBtn.TabIndex = 17;
            bookRoom_bookBtn.Text = "Book";
            bookRoom_bookBtn.UseVisualStyleBackColor = false;
            bookRoom_bookBtn.Click += bookRoom_bookBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 185);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 12;
            label8.Text = "Status";
            // 
            // bookRoom_status
            // 
            bookRoom_status.AutoSize = true;
            bookRoom_status.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bookRoom_status.Location = new Point(124, 185);
            bookRoom_status.Name = "bookRoom_status";
            bookRoom_status.Size = new Size(69, 20);
            bookRoom_status.TabIndex = 11;
            bookRoom_status.Text = "__________";
            // 
            // bookRoom_roomName
            // 
            bookRoom_roomName.AutoSize = true;
            bookRoom_roomName.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bookRoom_roomName.Location = new Point(124, 128);
            bookRoom_roomName.Name = "bookRoom_roomName";
            bookRoom_roomName.Size = new Size(69, 20);
            bookRoom_roomName.TabIndex = 10;
            bookRoom_roomName.Text = "__________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 128);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 9;
            label11.Text = "Room Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 67);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 8;
            label7.Text = "Room Type:";
            // 
            // bookRoom_roomType
            // 
            bookRoom_roomType.AutoSize = true;
            bookRoom_roomType.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bookRoom_roomType.Location = new Point(124, 67);
            bookRoom_roomType.Name = "bookRoom_roomType";
            bookRoom_roomType.Size = new Size(69, 20);
            bookRoom_roomType.TabIndex = 7;
            bookRoom_roomType.Text = "__________";
            // 
            // bookRoom_roomID
            // 
            bookRoom_roomID.AutoSize = true;
            bookRoom_roomID.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bookRoom_roomID.Location = new Point(124, 17);
            bookRoom_roomID.Name = "bookRoom_roomID";
            bookRoom_roomID.Size = new Size(69, 20);
            bookRoom_roomID.TabIndex = 6;
            bookRoom_roomID.Text = "__________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 17);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Room ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(16, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 472);
            panel3.TabIndex = 7;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(16, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(570, 396);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(bookRoom_imageView);
            panel5.Controls.Add(dataGridView2);
            panel5.Location = new Point(16, 516);
            panel5.Name = "panel5";
            panel5.Size = new Size(607, 306);
            panel5.TabIndex = 8;
            // 
            // bookRoom_imageView
            // 
            bookRoom_imageView.BackColor = SystemColors.ControlDark;
            bookRoom_imageView.Location = new Point(16, 16);
            bookRoom_imageView.Name = "bookRoom_imageView";
            bookRoom_imageView.Size = new Size(570, 265);
            bookRoom_imageView.SizeMode = PictureBoxSizeMode.Zoom;
            bookRoom_imageView.TabIndex = 11;
            bookRoom_imageView.TabStop = false;
            // 
            // staff_BookRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "staff_BookRoom";
            Size = new Size(955, 841);
            Load += staff_BookRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookRoom_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private Panel panel4;
        private Label bookRoom_total;
        private Label label14;
        private Button bookRoom_printBtn;
        private Button bookRoom_scheduleBtn;
        private Button bookRoom_clearBtn;
        private DateTimePicker bookRoom_to;
        private DateTimePicker bookRoom_from;
        private Label label13;
        private Label label12;
        private Button bookRoom_bookBtn;
        private Label label8;
        private Label bookRoom_status;
        private Label bookRoom_roomName;
        private Label label11;
        private Label label7;
        private Label bookRoom_roomType;
        private Label bookRoom_roomID;
        private Label label4;
        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private PictureBox bookRoom_imageView;
        private Label label2;
        private Label bookRoom_regPrice;
    }
}
