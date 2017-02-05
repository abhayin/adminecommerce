using Admin.IRepository;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        private IProductrepository _pr;
        private ICategoryRepository _cr;
        private ITagRepository _tg;
        private IOrderRepository _odr;
        private ISocialRepository _sinfo;
        
        public IProductrepository pr
        {
            get 
            {
                return _pr ?? (_pr = new ProductRepository(db));
            }
        }

        public ICategoryRepository cr
        {
            get
            {
                return _cr ?? (_cr = new CategoryRepository(db));
            }
        }

        public ITagRepository tg
        {
            get
            {
                return _tg ?? (_tg = new TagRepository(db));
            }
        }

        public IOrderRepository odr
        {
            get
            {
                return _odr ?? (_odr = new OrderRepository(db));
            }
        }

        public ISocialRepository sinfo
        {
            get
            {
                return _sinfo ?? (_sinfo = new SocialRepository(db));
            }
        }

        public UnitOfWork() { }
        
        public void dispose()
        {
            db.Dispose();
        }


    }
}