using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message
    {
        [Key]
        [Required]
        [MinLength(2)]
        public string MessageText { get; set; }
        [DataType(DataType.Date),]
        public DateTime DateSent { get{ return DateTime.Now; }} 
        
        public bool IsRead { get; set; } = false;
        

    }
}
