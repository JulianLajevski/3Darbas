using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Darbas
{
    public partial class LoginForm : Form
    {
        private UserRepository userRepository = new UserRepository();
        UserClass loggedInUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {

                loggedInUser = userRepository.Login(usernameTextBox.Text, passwordTextBox.Text);
                switch (loggedInUser.UserType)
                {
                    case UserType.Admin:
                        AdminFeedForm adminFeedForm = new AdminFeedForm(loggedInUser);
                        adminFeedForm.ShowDialog();
                        break;
                    case UserType.BasicUser:
                        UserFeedForm userFeedForm = new UserFeedForm(loggedInUser);
                        userFeedForm.ShowDialog();
                        break;
                }
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void hideShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hideShowCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void anonimLogInButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AnonymFeedForm anonymFeedForm = new AnonymFeedForm(loggedInUser);
            anonymFeedForm.ShowDialog();
            this.Close();
        }
    }
}
