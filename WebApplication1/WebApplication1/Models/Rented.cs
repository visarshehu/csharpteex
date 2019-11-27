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
        public int KMOnRent { get; set; }
        public int KMOnReturn { get; set; }
    }
}
