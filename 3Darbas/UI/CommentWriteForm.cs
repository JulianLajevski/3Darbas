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
    public partial class CommentWriteForm : Form
    {
        private Item item;
        private UserClass user;
        private SqlConnection conn;
        public CommentWriteForm(Item item, UserClass user)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
            this.item = item;
            itemTitleTextView.Text = item.Title;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            string sql = "insert into Comments (ItemId, UserId, Date, Text) values (@itemId, @userId, @date, @text)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@itemId", item.Id);
            cmd.Parameters.AddWithValue("@userId", user.id);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@text", commentTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Comment added!");
            this.Close();
        }
    }
}
