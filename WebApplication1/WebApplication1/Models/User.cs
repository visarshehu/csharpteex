using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class User
    {



        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       
        
        [Required]
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public List<CyberTruck> Truck { get; set; }

    }
}
