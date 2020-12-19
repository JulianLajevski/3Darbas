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
    public partial class CartListForm : Form
    {
        private SqlConnection conn;
        //ItemsRepository itemsRepository = new ItemsRepository();
        CartRepository cartRepository = new CartRepository();
        UserClass user;
        public CartListForm(UserClass user)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
            List<Item> cartItemsList = cartRepository.getCartItems(user);
            cartRepository.OnCurrentPrice += CartRepository_OnCurrentPrice;
            cartRepository.getCurrentPrice(user);


            itemsFlowPanel.Controls.Clear();

            if(cartItemsList.Count > 0)
            {
                totalTextView.Show();
                dolarTextView.Show();
                priceTextView.Show();
                buyButton.Show();
                noItemsTextView.Visible = false;
                foreach (Item item in cartItemsList)
                {
                    ItemUsercs userItem = new ItemUsercs(item, user);
                    userItem.showRemoveCartButton();
                    userItem.showBuyButton();
                    userItem.hideAddButton();
                    userItem.hideCommentButton();
                    itemsFlowPanel.Controls.Add(userItem);
                }
            }
            else
            {
                totalTextView.Hide();
                dolarTextView.Hide();
                priceTextView.Hide();
                buyButton.Hide();
                noItemsTextView.Visible = true;
            }
            

        }
        private void CartRepository_OnCurrentPrice(object sender, ItemEventArgs e)
        {
            priceTextView.Text = e.Price.ToString();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            List<Item> cartItemsList = cartRepository.getCartItems(user);

            var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                string sql = "INSERT INTO Orders (Date, User_Id) OUTPUT INSERTED.Id VALUES (@date, @userId)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@userId", user.id);
                conn.Open();
                int newOrderId = (int)cmd.ExecuteScalar();
                conn.Close();

                foreach(Item item in cartItemsList)
                {
                    insertItemOrder(newOrderId, item);
                }
            }
        }

        private void insertItemOrder(int orderId, Item item)
        {
            string sql = "INSERT INTO Order_Items (Item_Id, Order_Id) VALUES (@itemId, @orderId)" +
                         "DELETE FROM cart_items WHERE User_Id = @userId AND Item_Id = @itemId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@itemId", item.Id);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@userId", user.id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        

    }
}
