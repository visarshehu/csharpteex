using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string FirstName{ get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Key] public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<Cybertruck> Cybertrucks { get; set; }
    }
}
