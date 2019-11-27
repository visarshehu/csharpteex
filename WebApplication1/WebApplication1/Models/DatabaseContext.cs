using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DatabaseContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<CyberTruck> CyberTrucks { get; set; }
        DbSet<Order> Orders { get; set; }



        public DbSet<TestModel> TestModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=db02;Database=bv27263EX01;Trusted_Connection=True;");
        }
             
    }
}
