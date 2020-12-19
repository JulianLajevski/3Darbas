using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Darbas
{
    public partial class InfoChangeForm : Form
    {
        private UserClass user;
        private SqlConnection conn;

        public InfoChangeForm(UserClass user)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            this.user = user;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            
            if(currentPasswordTextBox.Text == user.getPassword())
            {
                if(newPasswordTextBox.Text != "" && newPasswordTextBox.Text != user.getPassword())
                {

                    string sql = "update Users set Password = @password where Username = @username";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", user.getUsername());
                    cmd.Parameters.AddWithValue("@password", newPasswordTextBox.Text);
                    user.SetPassword(newPasswordTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Password changed!");
                }
            }
            else
            {
                MessageBox.Show("Bad password!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
