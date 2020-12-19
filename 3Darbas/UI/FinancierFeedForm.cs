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
    public partial class FinancierFeedForm : AdminFeedForm
    {
        private UserClass user;
        public FinancierFeedForm(UserClass user): base(user)
        {
            InitializeComponent();
            addItemButton.Hide();
            addCattegoryButton.Hide();
            cartButton.Hide();
            myOrdersButton.Hide();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopingHistoryForm historyForm = new ShopingHistoryForm();
            historyForm.ShowDialog();
        }
    }
}
