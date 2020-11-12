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
    public partial class Form1 : Form
    {
        public static UserClass loggedInUser;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();

           /* if(loggedInUser != null)
            {
                UserHomeForm userHome = new UserHomeForm();
                userHome.ShowDialog();
            }
            if(loggedInAdmin != null)
            {
                AdminHomeForm adminHome = new AdminHomeForm();
                adminHome.ShowDialog();
            }
           */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}
