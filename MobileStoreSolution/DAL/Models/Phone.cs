using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Phone
    {

        public Phone()
        {
            Orders = new List<Order>();
        }


        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public List<Order> Orders { get; set; }


    }
}
