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
    public partial class itemCommentAdmin : itemComment
    {
        private SqlConnection conn;
        UserClass user;
        Comment comment;
        public itemCommentAdmin(UserClass user, Comment comment) :base(user, comment)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
            this.comment = comment;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "delete from Comments where Comment_Id = @commentId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@commentId", comment.commentId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted!");
        }
    }
}
