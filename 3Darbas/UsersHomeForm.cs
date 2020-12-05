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
    public partial class UsersHomeForm : Form
    {
        private UserClass user;
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
        public UsersHomeForm(UserClass user)
        {
            InitializeComponent();
            this.user = user;
            helloText.Text = $"Hello, {user.GetName()}!";
            if (user.GetProfilePicture() != null)
            {
                profilePictureBox.Image = user.GetProfilePicture();
                profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name: {user.GetName()}\nSurname: {user.GetSurname()}\n" +
                $"BirthDate: {user.GetBirthdate()}\nUsername: {user.getUsername()}\nPassword: {user.getPassword()}\n" +
                $"User Type: {user.UserType}");
        }

        private void changeInfoButton_Click(object sender, EventArgs e)
        {
            InfoChangeForm infoChange = new InfoChangeForm(user);
            infoChange.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePictureButton_Click(object sender, EventArgs e)
        {
            string sql = "update Users set Image = @image where Username = @username and Password = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", user.getUsername());
            cmd.Parameters.AddWithValue("@password", user.getPassword());
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                user.setProfilePicture(ofd.FileName);
                profilePictureBox.BackgroundImage = null;
                profilePictureBox.Image = bit;
                profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                cmd.Parameters.AddWithValue("@image", ofd.FileName);
            }
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
