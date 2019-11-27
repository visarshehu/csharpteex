using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace WebApplication1.Models
{
    public class User
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [PrimaryKey]
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(512)]
        [get: System.Security.SecurityCritical]
        [set: System.Security.SecurityCritical]
        public string Password { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime CreatedDate { get; set; }


        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime UpdatedDate { get; set; }

        public CyberTruck CyberTruck { get; set; }
    }
}
