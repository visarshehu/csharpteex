using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }
        public bool IsRead { set { IsRead = false; } }

        public ChatRoom ChatRoom { get; set; }
    }
}
