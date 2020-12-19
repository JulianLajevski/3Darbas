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

namespace _3Darbas
{
    public partial class ItemAdmin : ItemUsercs
    {
        private SqlConnection conn;
        Item item;
        UserClass user;
        public ItemAdmin(Item item, UserClass user) : base(item, user)
        {
            InitializeComponent();

            removeLabelButton.Hide();
            commentLabelButton.Hide();
            addLabelButton.Hide();
            this.item = item;
            this.user = user;
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            DeleteLinkButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void DeleteLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                deleteItemFromComment(item.Id, conn);
                deleteItemFromFavorite(item.Id, conn);
                string sql = "delete from Items where Id = @itemId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@itemId", item.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Item " + item.Title + " removed!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            

        }

        private void deleteItemFromFavorite(int itemId, SqlConnection conn)
        {
            string sql = "delete from Favorite_Items where Item_Id = @itemId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void deleteItemFromComment(int itemId, SqlConnection conn)
        {
            string sql = "delete from Comments where ItemId = @itemId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    
}
