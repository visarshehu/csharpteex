using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        [Key] public DateTime DateOfOrder { get; set; }
        public int Bid { get; set; }
        public User User { get; set; }
        public List<Cybertruck> Cybertrucks { get; set; }
    }
}
