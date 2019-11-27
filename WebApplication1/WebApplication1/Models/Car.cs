using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Car
    {
        public string Manufacturer { get; set;}
        public string Model { get; set;}
        public int Year { get; set;}
        public string FuelType { get; set;}
        public string LicencePlate { get; set;}
        public DateTime DateRegistered { get; set;}

    }
}
