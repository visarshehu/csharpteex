using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace ProjectManagement.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> FirstName { get; set; }
        public DbSet<User> LastName { get; set; }
        public DbSet<User> UserName { get; set; }
        public DbSet<User> Email { get; set; }

    }

    namespace WebApplication1.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DB02;Database=jm27015EX01;Trusted_Connection=True;");
        }
             
    }
}
