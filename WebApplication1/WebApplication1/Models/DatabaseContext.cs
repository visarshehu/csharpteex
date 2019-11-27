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
		public DbSet<Message> Messages { get; set; }
		public DbSet<User> User { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ChatRoom>()
				.HasKey(t => new { t.Username, t.MessageId });

			modelBuilder.Entity<ChatRoom>()
				.HasOne(pt => pt.User)
				.WithMany(p => p.ChatRooms)
				.HasForeignKey(pt => pt.Username);

			modelBuilder.Entity<ChatRoom>()
				.HasOne(pt => pt.Message)
				.WithMany(t => t.ChatRooms)
				.HasForeignKey(pt => pt.MessageId);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DB02;Database=ar27020EX1;Trusted_Connection=True;");
        }
             
    }
}
