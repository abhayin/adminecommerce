using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class OrderStatus
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
        public Order Order { get; set; }
    }
}