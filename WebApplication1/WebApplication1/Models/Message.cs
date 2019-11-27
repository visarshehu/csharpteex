using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message
    {

        public string MessageText { get; set; }
        DateTime DateSent = DateTime.Now;
        public DateTime DateSent { get; set;}
        public bool IsRead { get; set; }
        public DateTime DateSent1 { get => this.DateSent; set => this.DateSent = value; }
    }
}
