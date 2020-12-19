using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Darbas.Back;

namespace _3Darbas
{
   public class Item
    {
        public event EventHandler<ItemEventArgs> OnPriceShow;
        
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string Image { get; private set; }

        public double Price { get; private set; }

        public List<Item> favItemList { get; private set; }

        public Item(int id, string title, string description, string image, double price)
        {
            /*
            if (title == "")
                throw new Exception("Title is empty!");
            if(description == "")
                throw new Exception("Description is empty!");
            if(price == 0)
                throw new Exception("Price is empty!");
            if(image == null)
                throw new Exception("Image not choosed!"); */
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Price = price;
        }
        public void setFavItems(List<Item> items)
        {
            favItemList = items;
        }

        public void triggerPriceEvent()
        {
            OnPriceShow(this, new ItemEventArgs(199.9));
        }
    }
}
