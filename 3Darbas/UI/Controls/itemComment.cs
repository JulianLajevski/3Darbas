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
    public partial class itemComment : UserControl
    {
        private SqlConnection conn;
        Comment comment;

        public itemComment(UserClass user, Comment comment)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.comment = comment;
            userNameText.Text = user.GetName() + " " + user.GetSurname();
            userNameText.Text = getUserName(comment.userId);
            commentText.Text = comment.text;
            dateText.Text = comment.date.ToString();
        }

        public itemComment()
        {
            InitializeComponent();
        }

        public string getUserName(int userId)
        {
            string name = "";
            string surname = "";
            string sql = "select Name, Surname from Users where User_ID = @userId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();
                surname = reader["Surname"].ToString();
            }
            conn.Close();
            return name + " " + surname;
        }
        
    }
}
