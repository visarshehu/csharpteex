using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Car
    {
        [MaxLength(2)]
        [Required]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        [Key]
        public string LicencePlate { get; set; }
        public int DateRegistered { get; set; }
        [NotMapped]
        public List<User> User { get; set; }
    }
}
