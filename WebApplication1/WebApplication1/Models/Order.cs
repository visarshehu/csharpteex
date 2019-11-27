using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;


namespace WebApplication1.Models
{
    public class Order
    {
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime DateOfOrder { get; set; }

        public int bid { get; set; }

        public User User {get; set;}
    }
}
