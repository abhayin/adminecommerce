using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string InvoiceNo { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public ICollection<OrderItems> Items { get; set; }
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; }
    }
}