using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Message
	{
		public int Id { get; set; }
		[Required]
		[MinLength(2)]
		public string MessageText { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime DateSent { get; set; }
		public bool IsRead { get; set; } = false;
		public List<ChatRoom> ChatRooms { get; set; }
	}
}
