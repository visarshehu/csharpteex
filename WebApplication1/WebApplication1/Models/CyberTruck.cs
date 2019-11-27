using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CyberTruck
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Model { get; set; }
        [Required]
        public int Price { get; set; } = 0;
        [Required]
        public string Color { get; set; }
        [Required]
        public string EstimatedDelivery { get; set; }
    }
}
