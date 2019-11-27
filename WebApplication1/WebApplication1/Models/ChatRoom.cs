using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class ChatRoom
	{
		public string Username { get; set; }
		public User User { get; set; }

		public int MessageId { get; set; }
		public Message Message { get; set; }
		[Required]
		public string Name { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime DateCreated { get; set; }

	}
}
