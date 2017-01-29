using Admin.Dtos;
using Admin.Models;
using Admin.Repository;
using AutoMapper;
using System.Web.Mvc;
using System.Collections.Generic;

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
            return View(new ProductDto());
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

    }
}