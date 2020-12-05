using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas
{
    class FavoriteItem
    {
        public int Item_Id { get; private set; }

        public int User_Id { get; private set; }

        public List<Item> Items { get; private set; }

        public FavoriteItem(int item_id, int user_id)
        {
            Item_Id = item_id;
            User_Id = user_id;
        }
        public void setItems(List<Item> items)
        {
            Items = items;
        }
    }
}
