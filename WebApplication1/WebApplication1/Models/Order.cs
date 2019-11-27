using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        public Order()
        {
            new List<User>();
            new List<CyberTruck>();
        }

        public DateTime DateOfOrder { get; set; }
        public int Bid { get; set; }
    }
}
