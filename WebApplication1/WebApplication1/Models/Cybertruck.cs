using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cybertruck
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Model { get; set; }
        [Required]
        
        public int Price { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int EstimatedDelivery { get; set; }
        public User User { get; set; }
    }
}
