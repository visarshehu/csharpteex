using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string HasDriverLicence { get; set; }
        public int CreatedDate { get; set; }
        public int UpdateDate { get; set; }
        [NotMapped]
        public List<Car> Car { get; set; }
    }
}
