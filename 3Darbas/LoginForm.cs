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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {

                UserClass loggedInUser = userRepository.Login(usernameTextBox.Text, passwordTextBox.Text);
                switch (loggedInUser.UserType)
                {
                    case UserType.Admin:
                        AdminsHomeForm adminHomeForm = new AdminsHomeForm(loggedInUser);
                        adminHomeForm.ShowDialog();
                        break;
                    case UserType.BasicUser:
                        UsersHomeForm userHomeForm = new UsersHomeForm(loggedInUser);
                        userHomeForm.ShowDialog();
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

        
    }
}
