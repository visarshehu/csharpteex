﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Car
    { 
        [Required]
        [MinLength(2)]
        public string Manufacturer { get; set; }
        public string  Model { get; set; }
        public DateTime Year { get; set; }
        
        public string FuelType { get; set; }
        [PrimaryKey]
        public string LicencePlate { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRegistered { get; set; }


        public List<Rented> Rented{ get; set; }
    }
}
