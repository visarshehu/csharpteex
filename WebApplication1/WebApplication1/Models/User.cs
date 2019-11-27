using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public string FirstName { get;set;}
        public string LastName { get;set;}
        public string UserName { get;set;}
        
        public int Password { get; set;}
        public string Email { get; set;}
        public DateTime Birthdate { get; set;}
        public string HasDriverLicence { get; set;}
        public string CreatedDate { get; set;}
        public string UpdatedDate { get; set;}
    }
}
