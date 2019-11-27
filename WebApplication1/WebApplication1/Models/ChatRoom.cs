﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ChatRoom
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        
        public DateTime DateCreated { get { return DateTime.Now; } }
        
        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
