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
    public partial class clearUsersForm : Form
    {
        UserRepository userRepository = new UserRepository();
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public clearUsersForm()
        {
            InitializeComponent();
        }

        private void clearUsersForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "select * from Users where Type = 1";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lv.SubItems.Add(dr[5].ToString());
                usersListView.Items.Add(lv);
            }
            conn.Close();

            /*
            var people = userRepository.GetUserList();
            usersListView.Items.Clear();
            foreach (var user in people)
            {
                if(user.UserType == UserType.BasicUser)
                {
                    var row = new string[] { user.GetName(), user.GetSurname(), user.GetBirthdate(), user.getUsername(), user.getPassword()};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = user;
                    usersListView.Items.Add(lvi);
                }
            } */
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersListView.Items.Count != 0)
            {
                if (usersListView.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int index = this.usersListView.SelectedIndices[0];

                        if (usersListView.Items[index].Selected)
                        {
                            string name = this.usersListView.Items[index].SubItems[0].Text;
                            string surname = this.usersListView.Items[index].SubItems[1].Text;
                            string birthdate = this.usersListView.Items[index].SubItems[2].Text;
                            string username = this.usersListView.Items[index].SubItems[3].Text;
                            string password = this.usersListView.Items[index].SubItems[4].Text;

                            userRepository.DeleteUser(name, surname, username, password);
                            this.Close();
                        }
                        MessageBox.Show("Deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("No user choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No users in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
