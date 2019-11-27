using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CyberTruck
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Model { get; set; }
        [Required]
        public int Price { get; set; }

        public string Color { get; set; }
        public DateTime EstimatedDelivery { get; set; }

        public User User { get; set; }
    }
}
