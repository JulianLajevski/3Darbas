using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using _3Darbas.Back;

namespace _3Darbas.Back
{
    public class CartRepository
    {
        
        private SqlConnection conn;
        public event EventHandler<ItemEventArgs> OnCurrentPrice;
        public CartRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
        }

        public List<Item> getCartItems(UserClass user)
        {
            List<Item> cartItemList;

            List<Item> cartItemsList = new List<Item>();
            try
            {
                string sql = "select * from Items Where Id IN (select Item_Id from cart_items where User_Id = @userId)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", user.id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["Title"].ToString();
                    double price = double.Parse(reader["Price"].ToString());
                    string description = reader["Description"].ToString();
                    string image = reader["Image"].ToString();
                    cartItemsList.Add(new Item(id, title, description, image, price));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return cartItemsList;
        }

        public void getCurrentPrice(UserClass user)
        {
            double currentPrice = 0;

            string sql = "SELECT SUM (Items.Price) AS 'Price' " +
                         "FROM((Items " +
                         "INNER JOIN cart_items ON cart_items.Item_Id = Items.Id) " +
                         "INNER JOIN Users ON Users.User_ID = cart_items.User_Id ) WHERE Users.User_ID = @userId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", user.id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                 currentPrice = double.Parse(reader["Price"].ToString());
            }
            conn.Close();
            /*if (checkUserBonus(user.id))
            {
                if (user.GetDaysUntilBirthday() <= 7 || user.GetDaysUntilBirthday() >= 356)
                {
                    currentPrice = currentPrice * 0.9;
                    MessageBox.Show("You got 10% for all cart!");
                }
            }*/
            OnCurrentPrice(this, new ItemEventArgs(currentPrice));
        }

        public Boolean checkUserBonus(int userId)
        {
            Boolean userBonus = false;
            string sql = "SELECT User_Bonus.Value FROM User_Bonus WHERE User_Bonus.UserId = @userId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int userBonusValue = int.Parse(reader["Value"].ToString());

                if (userBonusValue == 1)
                    userBonus = true;
            }
            conn.Close();
            return userBonus;
        }
    }
}
