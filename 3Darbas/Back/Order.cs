using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas.Back
{
    class Order
    {
        private int Id;
        private string Date;
        private int UserId;

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
