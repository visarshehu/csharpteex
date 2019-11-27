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
        [Range(5, 20)]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [Required]
        [Key]
        public string Username { set; get; }
        [Required]
        public string Password { set; get; }
        public string Email { set; get; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Birthdate { set; get; }
        public bool HasDriverLicence { set; get; }
        public DateTime CreatedDate { set; get; }
        private DateTime Date = DateTime.Now;
        public DateTime UpdatedDate { get { return Date; } set { Date = value; } }
        public ICollection<Rented> Renteds { get; set; }

    }
}
