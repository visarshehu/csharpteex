using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rented
    {
       
        public DateTime DateOfRent { get; set; }
   
        public DateTime DateOfReturn { get; set; }
        [Required]
        public DateTime KMOnRent { get; set; }

        public DateTime KMOnReturn { get; set; }

        public int CarFuelType { get; set; }
        public Car Cars { get; set; }

        public int UserUserName { get; set; }
        public User Users { get; set; }
    }
}
