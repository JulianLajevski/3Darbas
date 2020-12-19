using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Darbas
{
    public partial class ItemAnonim : UserControl
    {
        public ItemAnonim(Item item)
        {
            InitializeComponent();
            titleTextView.Text = item.Title;
            descriptionTextView.Text = item.Description;
            priceTextView.Text = item.Price.ToString();
            itemImageBox.Image = Image.FromFile("pictures/" + item.Image);
        }
        public ItemAnonim()
        {
            InitializeComponent();
        }
    }
}
