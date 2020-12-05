using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Darbas
{
    class ItemsRepository
    {

        private SqlConnection conn;

        public ItemsRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
        }

        public List<Item> GetItems()
        {
            List<Item> itemsList = new List<Item>();
            try
            {
                string sql = "select Id, Title, Price, Description, Image from items";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string title = reader["Title"].ToString();
                    double price = double.Parse(reader["Price"].ToString());
                    string description = reader["Description"].ToString();
                    string image = reader["Image"].ToString();
                    itemsList.Add(new Item(id, title, description, image, price));

                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return itemsList;
        }

        public List<Category> GetCategories()
        {
            List<Category> categoriesList = new List<Category>();

            try
            {
                string sql = "select id, Title from categories";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["Title"].ToString();
                    categoriesList.Add(new Category(id, title));
                }
                conn.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            foreach(Category category in categoriesList)
            {
                category.setItems(GetItems(category.Id));
            }

            return categoriesList;
        }

        private List<Item> GetItems(int categoryId)
        {
            List<Item> itemsList = new List<Item>();
            try
            {
                string sql = "select Id, Title, Price, Description, Image from items where CategoryID = @category";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@category", categoryId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string title = reader["Title"].ToString();
                    double price = double.Parse(reader["Price"].ToString());
                    string description = reader["Description"].ToString();
                    string image = reader["Image"].ToString();
                    itemsList.Add(new Item(id, title, description, image, price));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return itemsList;
        }

        
        public List<Item> getFavoriteItems(int userId)
        {
            List<Item> favoriteItemList = new List<Item>();
            try
            {
                string sql = "select * from Items Where Id IN (select Item_Id from Favorite_Items where User_Id = @userId)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["Title"].ToString();
                    double price = double.Parse(reader["Price"].ToString());
                    string description = reader["Description"].ToString();
                    string image = reader["Image"].ToString();
                    favoriteItemList.Add(new Item(id, title, description, image, price));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return favoriteItemList;
        }

        public List<Comment> getCommentsList(int itemId)
        {
            List<Comment> commentsList = new List<Comment>();
            try
            {
                string sql = "select  ItemId, UserId, Date, Text, Comment_Id from Comments where ItemId = @itemID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@itemID", itemId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int commentId = int.Parse(reader["Comment_Id"].ToString());
                    int itemID = int.Parse(reader["ItemId"].ToString());
                    int userId = int.Parse(reader["UserId"].ToString());
                    DateTime dateTime = DateTime.Parse(reader["Date"].ToString());
                    string date = dateTime.ToString("yyyy-MM-dd");
                    string text = reader["Text"].ToString();
                    commentsList.Add(new Comment(commentId, itemID, userId, text, date));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return commentsList;
            
        }

    }
}
