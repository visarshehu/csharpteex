using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string email { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get{ return DateTime.Now; } }
        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get{ return DateTime.Now; } }//automatic da se naprae
    }
}
