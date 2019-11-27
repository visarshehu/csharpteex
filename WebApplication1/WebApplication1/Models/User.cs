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
        [Key]
        public string Username { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Fname { get; set; }

        [Required]
        public string Lname { get; set; }

      
        [Required]
        public string Password { get; set; }
        public EmailAddressAttribute Mail { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateTime { get; set; }
     

      

         
        
    }
}
