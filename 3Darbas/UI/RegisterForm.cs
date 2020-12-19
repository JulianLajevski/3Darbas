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
    public partial class RegisterForm : Form
    {
        private UserRepository userRepository = new UserRepository();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                    userRepository.AddBasicUser(nameTextBox.Text, surnameTextBox.Text, birthdayPicker.Value, usernameTextBox.Text, passwordTextBox.Text); 
                    this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                
            }
        }
    }
}
