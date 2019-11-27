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
        public DbSet<User> User { get; set; }
        public DbSet<Car> Car { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DB02;Database=dt26570EX01;Trusted_Connection=True;");
        }
             
    }
}
