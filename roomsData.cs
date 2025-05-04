using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management
{
    internal class roomsData
    {
        public string conn = @"Data Source=HZ\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True";

        public int ID {  set; get; }
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }


        public List<roomsData> roomsDataList()
        {
            List<roomsData> listData = new List<roomsData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = " SELECT * FROM rooms WHERE date_delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { 
                        roomsData rData =   new roomsData();

                        rData.ID = (int)reader["id"];
                        rData.RoomID = reader["room_id"].ToString();
                        rData.RoomType = reader["type"].ToString();
                        rData.RoomName = reader["room_name"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.Image = reader["image_path"].ToString();
                        rData.Status = reader["status"].ToString();
                        rData.Date = reader["date_register"].ToString();

                        listData.Add(rData);

                    }
                }
            }
            return listData;
        }

    }
}
