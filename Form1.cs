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
using System.Data;
using System.Security.Cryptography.Xml;

namespace Hotel_Management
{
    public partial class Form1 : Form
    {
        public string conn = @"Data Source=HZ\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void login_registerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Login successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using(SqlCommand getRole = new SqlCommand(selectRole,connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass",login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                if(userRole == "Admin")
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();

                                    this.Hide();
                                }
                                else if(userRole =="Staff")
                                {
                                    staffMainForm staffForm = new staffMainForm();
                                    staffForm.Show();

                                    this.Hide();
                                }
                            }

                            

                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

