using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas.Back
{
    public class ItemEventArgs : EventArgs
    {
        public double Price;
        public ItemEventArgs(double price)
        {
            Price = price;
        }
    }
}
