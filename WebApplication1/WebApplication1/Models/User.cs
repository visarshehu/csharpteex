using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;

/// <summary>
/// Summary description for Class1
/// </summary>
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
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }


        public string Email { get; set; }
        public DateTime CreatedTime = File.GetCreationTime(@"C:\Users\ak27062\source\repos\csharpteex\WebApplication1\WebApplication1\Models\User.cs");
        public DateTime UpdatedTime = File.GetLastWriteTime(@"C:\Users\ak27062\source\repos\csharpteex\WebApplication1\WebApplication1\Models\User.cs");


        public List<CyberTruck> CyberTrucks { get; set; }

        
        public int Id { get; set; }

    }
}