using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _3Darbas
{
    public partial class AdminFeedForm : UserFeedForm
    {
        private UserClass user;
        public AdminFeedForm(UserClass user): base(user)
        {
            InitializeComponent();
            favoritesButton.Hide();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItemForm newItemForm = new AddNewItemForm();
            newItemForm.ShowDialog();
        }

        private void addCattegoryButton_Click(object sender, EventArgs e)
        {
            NewCattegoryInputForm newCategoryForm = new NewCattegoryInputForm();
            newCategoryForm.ShowDialog();
        }
    }
}
