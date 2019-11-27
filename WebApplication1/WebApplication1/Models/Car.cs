using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Car : MyEntity
    {
        [Required]
        [MinLength(2)]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    
        public DateTime Year { get; set; }
        public string FuelType { get; set; }
        [Key]
        public string LicensePlate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)
        public DateTime DateRegistered { get; set; }

        public List<Rented> Rents { get; set; }
    }
}