using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class admin_customers : UserControl
    {
        public admin_customers()
        {
            InitializeComponent();

            displayCustomers();
        }

        public void displayCustomers()
        {
            customersData cData = new customersData();

            List<customersData> listData = cData.customerListData();

            dataGridView1.DataSource = listData;
        }
    }
}
