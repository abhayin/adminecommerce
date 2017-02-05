using Admin.IRepository;
using Admin.Models;
using Admin.Repository;
using Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class OrderController : Controller
    {
        private IUnitOfWork repo;
        public OrderController()
        {
            repo = new UnitOfWork();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var orders = new OrderViewModel()
            {
                PendingOrders = repo.odr.GetPendingOrders(),
                DispatchedOrders = repo.odr.GetDispatchedOrders(),
                DeliveredOrders = repo.odr.GetDeliveredOrders()
            };
            return View(orders);
        }
    }
}