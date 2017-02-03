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


        public UnitOfWork()
        {

        }


    }
}