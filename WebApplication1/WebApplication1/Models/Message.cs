using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message
    {
        string MessageText { get; set; }
        DateTime DateSent { get; set; }
        bool IsRead { get; set; }
    }
}
