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
    public partial class NewCattegoryInputForm : Form
    {

        private SqlConnection conn;
        public NewCattegoryInputForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            string sql = "insert into Categories (Title) values ( @title)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@title", newCategoryTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Category " + newCategoryTextBox.Text + " succesfully added!");
            this.Close();
        }
    }
}
