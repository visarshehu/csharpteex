using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rented : Car
    {
        public DateTime DateOfRent { set; get; }
        public DateTime DateOfReturn { set; get; }
        public string KMOnRent { set; get; }
        public string KMOnReturn { set; get; }
        public User Users { get; set; }
        public Car Cars { get; set; }

    }
}
