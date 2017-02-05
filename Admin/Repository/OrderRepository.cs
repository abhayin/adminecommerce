using Admin.IRepository;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Admin.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext db;
        private readonly string Pending = "Pending";
        private readonly string Dispatch = "Dispatch";
        private readonly string Delivered = "Delivered";

        private OrderRepository() { }

        public OrderRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Order> GetPendingOrders()
        {
            var orders = db.Orders.Include(o=>o.Status).Where(o => o.Status.Status == Pending).ToList();
            return orders;
        }

        public IEnumerable<Order> GetDispatchedOrders()
        {
            var orders = db.Orders.Include(o => o.Status).Where(o => o.Status.Status == Dispatch).ToList();
            return orders;
        }

        public IEnumerable<Order> GetDeliveredOrders()
        {
            var orders = db.Orders.Include(o => o.Status).Where(o => o.Status.Status == Delivered).ToList();
            return orders;
        }

    }
}