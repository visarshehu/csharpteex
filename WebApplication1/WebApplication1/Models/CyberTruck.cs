using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CyberTruck
    {
      
        public int id { get; set; }
        public string Model { get; set; }
        public float price { get; set; }
        [Required]
        public string Color { get; set; }
        public DateTime EstimatedDelivery { get; set; }

    }
}
