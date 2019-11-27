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
        [MinLength(5)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [PrimaryKey]
        public string UserName { get; set; }
        [Required]
       
        public string Password { get; set; }
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{ yyyy}")]
        public DateTime Birthdate { get; set; }
        public bool HasDriverLicence { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CreatedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt
        { get; set; }
       
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string ModifiedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedAt { get; set; }

        public DateTime UpdatedDate { get; set; }

        public List<Rented> Rented { get; set; }

    }
}
