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
            builder.UseSqlServer(@"Server=.\SQL330;Database=EXAM;Trusted_Connection=True;");
        }
             
    }
}
