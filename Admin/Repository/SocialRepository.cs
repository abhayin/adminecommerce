using Admin.IRepository;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Repository
{
    public class SocialRepository : ISocialRepository
    {
        private ApplicationDbContext db;
        private SocialRepository() { }
        public SocialRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public SocialInformation IsAvailable(string UserId)
        {

            var socialinfo = db.SocialInformation.Where(s => s.UserId == UserId).FirstOrDefault();
            if (socialinfo != null)
                return socialinfo;
            else
                return new SocialInformation();
        }

        public void UpdateInformation(SocialInformation model)
        {
            var updateInfo = db.SocialInformation.Find(model.UserId);
            updateInfo = model;
            db.SaveChanges();
        }

    }
}