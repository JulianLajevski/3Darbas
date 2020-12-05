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
    public partial class UserFeedForm : AnonymFeedForm
    {
        private UserClass user;
        public UserFeedForm(UserClass user) :base(user)
        {
            InitializeComponent();
            this.user = user;
            goToProfileButton.Text = user.GetName() + " " + user.GetSurname();
            profileImageView.Image = user.GetProfilePicture();
        }

        public UserFeedForm()
        {
            InitializeComponent();
        }

        private void goToProfileButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(user.UserType == UserType.BasicUser)
            {
                
                UsersHomeForm userHomeForm = new UsersHomeForm(user);
                userHomeForm.ShowDialog();
            }
            else
            {
                
                AdminsHomeForm adminHomeForm = new AdminsHomeForm(user);
                adminHomeForm.ShowDialog();
            }
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            FavoriteItemsForm favItemsForm = new FavoriteItemsForm(user);
            favItemsForm.ShowDialog();
        }

        
    }
}
