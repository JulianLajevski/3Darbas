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
    public partial class FavoriteItemsForm : Form
    {
        private ItemsRepository itemsRepository;
        UserClass user;
        public FavoriteItemsForm(UserClass user)
        {
            InitializeComponent();
            this.user = user;

            itemsRepository = new ItemsRepository();
            List<Item> favList = itemsRepository.getFavoriteItems(user.id);
            
            foreach(Item item in favList)
            {
                ItemUsercs itemUser = new ItemUsercs(item, user);
                itemUser.hideAddButton();
                itemUser.showRemoveButton();
                listFlowPanel.Controls.Add(itemUser);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
