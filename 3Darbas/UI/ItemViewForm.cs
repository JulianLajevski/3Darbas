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

namespace _3Darbas
{
    public partial class ItemViewForm : Form
    {
        private SqlConnection conn;
        UserClass user;
        Item item;
        public ItemViewForm(UserClass user, Item item)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
            this.item = item;

            itemTitle.Text = item.Title;
            itemDescription.Text = item.Description;
            itemPrice.Text = item.Price.ToString();
            itemPicture.Image = Image.FromFile("pictures/" + item.Image);
        }

        private void allCommentsLabelButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemCommentsForm commentsForm = new ItemCommentsForm(user, item);
            commentsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into cart_items(Item_Id, User_Id) values (@itemId, @userID)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", user.getId());
            cmd.Parameters.AddWithValue("@itemId", item.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added to cart!");
        }
    }
}
