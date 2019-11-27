using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(2)]

        [Key]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Password { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Updated date")]
        public DateTime UpdatedDate { get; set; }
    }
}
