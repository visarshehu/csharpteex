using Microsoft.EntityFrameworkCore;

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
        public DbSet<User> Users { get; set; }
        public DbSet<CyberTruck> CyberTrucks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public object TodoLists { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=db02;Database=ak27062ex01;Trusted_Connection=True;");
        }
             
    }
}
