using Admin.IRepository;
using Admin.Models;
using Admin.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Admin.ViewModels;

namespace Admin.Controllers
{
    public class SocialController : Controller
    {
        private IUnitOfWork repo;
        public SocialController()
        {
            repo = new UnitOfWork();
        }

        [HttpGet]
        public ActionResult Information()
        {
            try
            {
                string UserId = User.Identity.GetUserId();
                var ViewModel = new SocialViewModel()
                {
                    SocialInformation = repo.sinfo.IsAvailable(UserId)
                };
                return View(ViewModel);
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult Update(SocialViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    repo.sinfo.UpdateInformation(model.SocialInformation);
                    return RedirectToAction("Information");
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                return View(model);
            }
            
        }
    }
}