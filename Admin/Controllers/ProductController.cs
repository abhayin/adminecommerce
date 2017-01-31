using Admin.Dtos;
using Admin.Models;
using Admin.Repository;
using AutoMapper;
using System.Web.Mvc;
using System.Collections.Generic;
using Admin.ViewModels;
using Admin.IRepository;

namespace Admin.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository repo;
        public ProductController()
        {
            repo = new ProductRepository(new Models.ApplicationDbContext());
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SetProduct()
        {
            ViewBag.TypeOfController = "";
            var viewModel = new ProductViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(ProductDto model)
        {
            repo.Add(Mapper.Map<ProductDto, Product>(model));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(ProductDto model)
        {
            repo.Update(Mapper.Map<ProductDto, Product>(model));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Remove(int Id)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveBetweenRange(int[] Ids)
        {
            return RedirectToAction("Index");
        }

    }
}