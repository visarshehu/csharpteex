using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Car
    {
        [Range(5, 255)]
        public string Manufacturer { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public string FuelType { set; get; }
        [Key]
        public string LicencePlate { set; get; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime DateRegistered { set; get; }
        public ICollection<Rented> Renteds { get; set; }
    }
}
