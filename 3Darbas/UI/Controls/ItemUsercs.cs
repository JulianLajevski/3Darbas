using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _3Darbas.Back;

namespace _3Darbas
{
    public partial class ItemUsercs : ItemAnonim
    {
        CartRepository cartRepository;
        private SqlConnection conn;
        UserClass user;
        Item item;
        public ItemUsercs(Item item, UserClass user) : base(item)
        {
            InitializeComponent();
            buyButton.Hide();
            removeLabelButton.Hide();
            removeLinkLabelCart.Hide();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
            this.item = item;
        }

        public ItemUsercs()
        {
            InitializeComponent();
        }

        public ItemUsercs (Item item): base(item)
        {
            this.item = item;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addFavoriteItem(item);
            MessageBox.Show("Added to favorite!");
        }

        private void addFavoriteItem(Item item)
        {
            string sql = "insert into Favorite_Items(Item_Id, User_Id) values (@itemId, @userID)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", user.getId());
            cmd.Parameters.AddWithValue("@itemId", item.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommentWriteForm commentForm = new CommentWriteForm(item, user);
            commentForm.ShowDialog();
        }

        private void removeLabelButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string sql = "delete from Favorite_Items where Item_Id = @itemId and User_Id = @userId ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@itemId", item.Id);
                cmd.Parameters.AddWithValue("@userId", user.id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            MessageBox.Show("Successfully removed!");
           
        }
        public void hideRemoveButton()
        {
            removeLabelButton.Hide();
        }
        public void showRemoveButton()
        {
            removeLabelButton.Show();
        }
        public void hideAddButton()
        {
            addLabelButton.Hide();
        }
        public void showAddButton()
        {
            addLabelButton.Show();
        }
        public void showRemoveCartButton()
        {
            removeLinkLabelCart.Show();
        }
        public void hideRemoveCartButton()
        {
            removeLinkLabelCart.Hide();
        }

        public void hideBuyButton()
        {
            buyButton.Hide();
        }

        public void showBuyButton()
        {
            buyButton.Show();
        }

        public void hideCommentButton()
        {
            commentLabelButton.Hide();
        }

        public void showCommentButton()
        {
            commentLabelButton.Show();
        }

        public void hidePriceText()
        {
            label3.Hide();
            priceTextView.Hide();
        }
        private void allCommentsLabelButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemCommentsForm commentsForm = new ItemCommentsForm(user, item);
            commentsForm.ShowDialog();
        }

        private void removeLinkLabelCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deleteItemFromCart(item, user);
            CartListForm.ActiveForm.Close();
        }

        private void addLinkLabelCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addItemToCart(item);
            MessageBox.Show("Added to cart!");
            cartRepository = new CartRepository();
            cartRepository.OnCurrentPrice += CartRepository_OnCurrentPrice;
            cartRepository.getCurrentPrice(user);
            
        }

        private void CartRepository_OnCurrentPrice(object sender, ItemEventArgs e)
        {
            MessageBox.Show("Cart price now: " + e.Price.ToString());
        }

        private void addItemToCart(Item item)
        {
            string sql = "insert into cart_items(Item_Id, User_Id) values (@itemId, @userID)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", user.getId());
            cmd.Parameters.AddWithValue("@itemId", item.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteItemFromCart(Item item, UserClass user)
        {
            try
            {
                string sql = "delete from cart_items where Item_Id = @itemId and User_Id = @userId ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@itemId", item.Id);
                cmd.Parameters.AddWithValue("@userId", user.id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            MessageBox.Show("Successfully removed!");
        }

        private void itemImageBox_Click(object sender, EventArgs e)
        {
            ItemViewForm itemForm = new ItemViewForm(user, item);
            itemForm.ShowDialog();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            double price = item.Price;
            string sql = "INSERT INTO Orders (Date, User_Id, Price) OUTPUT INSERTED.Id VALUES (@date, @userId, @price)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@userId", user.id);
            cmd.Parameters.AddWithValue("@price", price);
            conn.Open();
           int newOrderId = (int) cmd.ExecuteScalar();
            conn.Close();

            var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                insertItemOrder(newOrderId);
                MessageBox.Show("Bought!");
            }
        }
        
        private void insertItemOrder(int orderId)
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
