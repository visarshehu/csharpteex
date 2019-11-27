using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rented:MyEntity
    {
       
       
            [Key]
            public string LicensePlate { get; set; }
            [Key]
            public Car Car { get; set; }

            public string Username { get; set; }
            public User User { get; set; }
            
            public DateTime DateofRent { get; set; }
            
            public DateTime DateofReurn { get; set; }
            [Required]
            public int KMOnRent { get; set; }
            public int KMOnReturn { get; set; }
        

    }
}
