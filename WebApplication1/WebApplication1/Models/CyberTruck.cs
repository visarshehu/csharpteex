using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CyberTruck
    {
        public int Id { get; set; }
        [MinLength(2)]
        [Required]
        public string Model { get; set; }
        [Required]

        public int Price { get; set; }

        public string Color { get; set; }

        public int EstimatedDelivery { get; set; }

    }
}
