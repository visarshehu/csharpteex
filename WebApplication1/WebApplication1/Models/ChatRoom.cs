using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ChatRoom
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }

    }
}
