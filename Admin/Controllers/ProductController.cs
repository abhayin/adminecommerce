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
        //private ProductRepository repo;
        //private ICategoryRepository Icate;

        private IUnitOfWork repo;

        public ProductController()
        {
            repo = new UnitOfWork();
        }
        public ActionResult Index()
        {
            var pl = repo.pr.GetAllProducts();
            return View();
        }

        [HttpGet]
        public ActionResult SetProduct()
        {
            var viewModel = new ProductViewModel()
            {
                StatusDropdown = repo.pr.GetDisplayStatus(),
                CategoryDropdown = repo.cr.GetCategories()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.pr.Add(Mapper.Map<ProductDto, Product>(model.ProductDto));
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View("SetProduct", model);
                }
            }

            return View("SetProduct", model);

        }

        [HttpPost]
        public ActionResult Edit(ProductDto model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.pr.Add(Mapper.Map<ProductDto, Product>(model));
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View("SetProduct", model);
                }
            }

            return View("SetProduct", model);
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