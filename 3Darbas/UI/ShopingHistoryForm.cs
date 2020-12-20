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
using _3Darbas.Back;
using Newtonsoft.Json;
using System.IO;

namespace _3Darbas
{
    public partial class ShopingHistoryForm : Form
    {
        private SqlConnection conn;
        private OrderRepository orderRepository = new OrderRepository();
        int orderId = 0;
        public ShopingHistoryForm()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            List<Order> allOrderList = orderRepository.getAllOrders();
            foreach (Order order in allOrderList)
                ordersDropList.Items.Add(order.id.ToString());

            if (ordersDropList.Items.Count > 0)
            {
                ordersDropList.SelectedIndex = 0;
            }
        }

        private void selectedIndexChanged(object sender, EventArgs e)
        {
            orderItemPanel.Controls.Clear();

             orderId = int.Parse(ordersDropList.SelectedItem.ToString());
            string sql = "SELECT Items.Id, Items.Title, Items.Price, Items.Description, Items.Image FROM (((Items " +
                        "INNER JOIN Order_Items ON Order_Items.Item_Id = Items.Id )" +
                        "INNER JOIN Orders ON Order_Items.Order_Id = Orders.Id)" +
                        "INNER JOIN Users ON Orders.User_Id = Users.User_ID) WHERE Orders.Id = @orderId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string title = reader["Title"].ToString();
                double price = double.Parse(reader["Price"].ToString());
                string description = reader["Description"].ToString();
                string image = reader["Image"].ToString();
                Item item = new Item(id, title, description, image, price);
                ItemUsercs userItem = new ItemUsercs(item);
                userItem.hidePriceText();
                orderItemPanel.Controls.Add(userItem);

            }
            conn.Close();
            Order order = getOrderInfo(orderId);
            label2.Text = "Order Nr: " + order.Id.ToString() + "\nDate: " + order.Date + "\nPrice: " + order.Price.ToString() + "\nCustemer: " + order.Name + " " + order.Surname;
        }

        private Order getOrderInfo(int orderId)
        {
            Order order = null;
            double orderPrice = getOrderPrice(orderId);
            string sql = "SELECT Users.User_ID, Orders.Id, Orders.Date, Users.Name, Users.Surname FROM ((Orders " +
                         "INNER JOIN Users ON Users.User_ID = Orders.User_Id)) WHERE Orders.Id = @orderId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int userId = int.Parse(reader["User_ID"].ToString());
                int orderID = int.Parse(reader["Id"].ToString());
                DateTime dateTime = DateTime.Parse(reader["Date"].ToString());
                string date = dateTime.ToString("yyyy-MM-dd");
                string Name = reader["Name"].ToString();
                string Surname = reader["Surname"].ToString();

                order = new Order(orderID, date, userId, orderPrice, Name, Surname);
            }
            conn.Close();
            return order;
        }
        private double getOrderPrice(int orderId)
        {
            double price = 0;
            string sql = "SELECT Orders.Price FROM Orders WHERE Orders.Id = @orderId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                price = double.Parse(reader["Price"].ToString());
            }
            conn.Close();

            return price;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jsonButton_Click(object sender, EventArgs e)
        {

            Order order = getOrderInfo(orderId);
            
            string JsonOutPut = JsonConvert.SerializeObject(order);
            
            StreamWriter File = new StreamWriter("Json.txt", true);
            File.Write(JsonOutPut + "\n\n");
            File.Close();
        }
    }
}
