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
        
        public DbSet<Order> Order { get; set; }
        public DbSet<CyberTruck> CyberTruck { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DB02;Database=ss27100EX01;Trusted_Connection=True;");
        }
             
    }
}
