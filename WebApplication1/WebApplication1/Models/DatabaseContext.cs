using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DatabaseContext : DbContext
    {
      
        public DbSet<TestModel> TestModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DB02;Database=vc26999EX01;Trusted_Connection=True;");
        }

        public class User
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Username { get; set; }
            string Password { get; set; }
            string Email { get; set; }
            DateTime CreatedDate { get; set; }
            DateTime UpdatedDate { get; set; }
        }

        public class Message
        {
            string MessageText { get; set; }
            DateTime DateSent { get; set; }
            bool IsRead { get; set; }
        }
    }
}
