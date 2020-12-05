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
    public partial class ItemUsercs : ItemAnonim
    {
        private SqlConnection conn;
        UserClass user;
        Item item;
        public ItemUsercs(Item item, UserClass user) : base(item)
        {
            InitializeComponent();
            removeLabelButton.Hide();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
            this.item = item;
        }

        public ItemUsercs()
        {
            InitializeComponent();
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

        private void allCommentsLabelButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemCommentsForm commentsForm = new ItemCommentsForm(user, item);
            commentsForm.ShowDialog();
        }
    }
}
