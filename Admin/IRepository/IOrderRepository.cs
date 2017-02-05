using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.IRepository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetPendingOrders();
        IEnumerable<Order> GetDispatchedOrders();
        IEnumerable<Order> GetDeliveredOrders();
    }
}
