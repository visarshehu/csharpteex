using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Order
    {
        public DateTime DateOfOrder { get; set; }
        [Key]
        public int Bid { get; set; }

        public List<CyberTruck> CyberTruck { get; set; }

        public List<User> User { get; set; }

        

    }
}
