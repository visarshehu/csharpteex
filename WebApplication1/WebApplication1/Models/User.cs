using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class User
	{
		[Key]
		public string Username { get; set; }
		[Required]
		[MaxLength(20)]
		[MinLength(5)]
		public string Firstname { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string Password { get; set; }
		public string Email { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime CreatedDate { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime UpdatedDate { get; set; }
		public List<ChatRoom> ChatRooms { get; set; }
	}
}
