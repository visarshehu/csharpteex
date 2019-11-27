using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace WebApplication1.Models
{
    public class CyberTruck
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [System.ComponentModel.DefaultValue("$0")]
        public decimal Price { get; set; } = 0;

        [Required]
        public string Color { get; set; }

        [Required]
        public DateTime EstimatedDelivery { get; set; }

        public ICollection<User> User { get; set; }
    }
}
