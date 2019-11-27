using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rented
    {
        public DateTime DateOfRent { get; set;}
        public DateTime DateOfReturn { get; set;}
        public int KMOnRent { get; set;}
        public int KMOnReturn { get; set;}

        public User Users { get; set;}
        public Car Cars { get; set;}
    }
}
