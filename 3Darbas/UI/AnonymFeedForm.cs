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
    public partial class AnonymFeedForm : Form
    {
        private ItemsRepository itemsRepository;
        UserClass user;

        public AnonymFeedForm(UserClass user)
        {
            InitializeComponent();
            this.user = user;

            itemsRepository = new ItemsRepository();
            List<Category> categoriesList = itemsRepository.GetCategories();

            foreach(Category category in categoriesList)
            {
                Button categoryButton = new Button();
                categoryButton.Text = category.Title;
                categoryButton.Font = new Font("Microsoft Tai Le", 10, FontStyle.Bold);
                categoryButton.Height = 40;
                categoryButton.Width = 100;
                categoryButton.ForeColor = Color.White;
                categoryButton.BackColor = Color.FromArgb(47, 110, 165);
                categoryButton.FlatStyle = FlatStyle.Popup;
                categoryButton.Click += CategoryButton_Click;
                categoryButton.Tag = category;
                topFlowPanel.Controls.Add(categoryButton);
                
            }

        }

        public AnonymFeedForm()
        {
            InitializeComponent();
        }

            private void CategoryButton_Click(object sender, EventArgs e)
            {
            mainFlowPanel.Controls.Clear();
           
            Button button = (Button)sender;
            Category category = (Category) button.Tag;
            
            if(user == null)
            {
                foreach (Item item in category.Items)
                {
                    ItemAnonim itemAnonim = new ItemAnonim(item);
                    mainFlowPanel.Controls.Add(itemAnonim);
                }
            }
            if(user != null && user.UserType == UserType.BasicUser)
            {
                foreach (Item item in category.Items)
                {
                    ItemUsercs itemUser = new ItemUsercs(item, user);
                    mainFlowPanel.Controls.Add(itemUser);
                }
            }
            if(user != null && user.UserType == UserType.Admin)
            {
                foreach (Item item in category.Items)
                {
                    ItemAdmin itemAdmin = new ItemAdmin(item, user);
                    mainFlowPanel.Controls.Add(itemAdmin);
                }
            }
            if (user != null && user.UserType == UserType.Financier)
            {
                foreach (Item item in category.Items)
                {
                    ItemUsercs itemUser = new ItemUsercs(item, user);
                    mainFlowPanel.Controls.Add(itemUser);
                }
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
