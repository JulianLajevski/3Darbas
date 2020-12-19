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

namespace _3Darbas
{
    public partial class ShopingHistoryForm : Form
    {
        private SqlConnection conn;
        private OrderRepository orderRepository = new OrderRepository();
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

            int orderId = int.Parse(ordersDropList.SelectedItem.ToString());
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
            label2.Text = getOrderInfo(orderId);
        }

        private string getOrderInfo(int orderId)
        {
            string orderInfo = null;
            string orderPrice = getOrderPrice(orderId).ToString();
            string sql = "SELECT Orders.Id, Orders.Date, Users.Name, Users.Surname FROM ((Orders " +
                         "INNER JOIN Users ON Users.User_ID = Orders.User_Id)) WHERE Orders.Id = @orderId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime dateTime = DateTime.Parse(reader["Date"].ToString());
                string date = dateTime.ToString("yyyy-MM-dd");
                string Name = reader["Name"].ToString();
                string Surname = reader["Surname"].ToString();

                orderInfo = "Order Nr: " + orderId.ToString() + "\nDate: " + date + "\nPrice: " + orderPrice + "\nCustemer: " + Name + " " + Surname;

            }
            conn.Close();
            return orderInfo;
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
    }
}
