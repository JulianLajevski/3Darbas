using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas.Back
{
    class Order
    {
        public int Id { get; private set; }
        public string Date { get; private set; }
        public int UserId { get; private set; }
        public double Price { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }


        public Order(int id, string date, int userId, double price, string name, string surname)
        {
            Id = id;
            Date = date;
            UserId = userId;
            Price = price;
            Name = name;
            Surname = surname;
        }
        public Order(int id, string date, int userId)
        {
            Id = id;
            Date = date;
            UserId = userId;
        }

        internal int id
        {
            get => Id; set => Id = value;
        }

        internal string date
        {
            get => Date; set => Date = value;
        }
    }
}
