using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;

namespace Hotel_Management
{
    public partial class admin_room_Form : UserControl
    {
        public string conn = @"Data Source=HZ\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True";

        public admin_room_Form()
        {
            InitializeComponent();

            displayRoomsData();
        }
        public void displayRoomsData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listID = rData.roomsDataList();

            dataGridView1.DataSource = listID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_roomID.Text) || string.IsNullOrEmpty(rooms_roomName.Text)
                || rooms_type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_price.Text)
                || rooms_status.SelectedIndex == -1 || rooms_picture.Image == null)
            {
                return true;
            }
            else { return false; }
        }


        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkRoomID = "SELECT room_id FROM rooms WHERE room_id = @roomID";
                        using (SqlCommand checkRID = new SqlCommand(checkRoomID, connect))
                        {
                            checkRID.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkRID);

                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(rooms_roomID.Text.Trim() + "is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register)" +
                                    "VALUES(@roomID, @type, @name, @price, @path, @status, @date_reg";
                                string path = Path.Combine(@"D:\Code winform\Hotel Management\room_directory\" + rooms_roomID.Text.Trim() + ".jng");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(rooms_picture.ImageLocation, path, true);


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@name", rooms_roomName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@path", path); // anh




                                    cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@date_reg", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    displayRoomsData();


                                    MessageBox.Show("Added Succesfully! ", "Imformation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex, "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }

        private void rooms_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";

                file.Filter = "Image Files (*.jng; *.png) |*.jpg;*.png";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    rooms_picture.ImageLocation = imagePath;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void rooms_updateBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to UPDATE ID : " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET room_id = @roomID, type = @type, room_name = @name, price = @price, status = @status, date_update = @update WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms_type.SelectedText.ToString());
                                cmd.Parameters.AddWithValue("@name", rooms_roomName.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", rooms_status.Text.Trim());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@update", today);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();

                                clearFields();

                                displayRoomsData();

                                MessageBox.Show("Updated succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :((", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                rooms_roomID.Text = row.Cells[1].Value.ToString();
                rooms_type.Text = row.Cells[2].Value.ToString();
                rooms_roomName.Text = row.Cells[3].Value.ToString();
                rooms_price.Text = row.Cells[4].Value.ToString();

                rooms_picture.ImageLocation = row.Cells[5].Value.ToString();
                rooms_status.Text = row.Cells[6].Value.ToString();


            }
        }

        public void clearFields()
        {
            rooms_roomID.Text = "";
            rooms_type.SelectedItem = -1;
            rooms_roomName.Text = "";
            rooms_price.Text = "";
            rooms_picture.Image = null;
            rooms_status.SelectedItem = -1;
        }
        private void rooms_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to DELETE ID : " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET date_delete = @delete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@delete", today);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();

                                clearFields();

                                displayRoomsData();

                                MessageBox.Show("Delete succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}
