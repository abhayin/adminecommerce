using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Admin.Models;

namespace Admin.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            PendingOrders = new HashSet<Order>();
            DispatchedOrders = new HashSet<Order>();
            DeliveredOrders = new HashSet<Order>();
        }
        public IEnumerable<Order> PendingOrders { get; set; }
        public IEnumerable<Order> DispatchedOrders { get; set; }
        public IEnumerable<Order> DeliveredOrders { get; set; }
    }
}