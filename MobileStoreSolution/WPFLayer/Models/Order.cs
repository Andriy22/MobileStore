using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    public class Order
    {
        public int ID { get; set; }

        public Phones Phone { get; set; }

        public User User { get; set; }

        public DateTime Date { get; set; }
    }
}
