using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas
{
    class Category
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public List<Item> Items { get; private set; }

        public Category(int id, string title)
        {
           
            if (title == "")
                throw new Exception("Category title is empty!");

            Id = id;
            Title = title;
        }

        public void setItems(List<Item> items)
        {
            Items = items;
        }
    }
}
