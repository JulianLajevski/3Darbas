using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _3Darbas.Back
{
    class OrderRepository
    {
        private SqlConnection conn;

        public OrderRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
        }

        public List<Order> getOrdersByUserId(int userId)
        {
            List<Order> orderList = new List<Order>();
            try
            {
                string sql = "SELECT Orders.Id, Orders.Date, Orders.User_Id FROM Orders WHERE Orders.User_Id = @userId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    DateTime datetime = DateTime.Parse(reader["Date"].ToString());
                    string date = datetime.ToString("yyyy-MM-dd");
                    int userID = int.Parse(reader["User_Id"].ToString());
                    orderList.Add(new Order(id, date, userID));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return orderList;
        }


        public List<Order> getAllOrders()
        {
            List<Order> allOrderList = new List<Order>();
            try
            {
                string sql = "SELECT Orders.Id, Orders.Date, Orders.User_Id FROM Orders";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    DateTime datetime = DateTime.Parse(reader["Date"].ToString());
                    string date = datetime.ToString("yyyy-MM-dd");
                    int userID = int.Parse(reader["User_Id"].ToString());
                    allOrderList.Add(new Order(id, date, userID));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return allOrderList;
        }
    }
}
