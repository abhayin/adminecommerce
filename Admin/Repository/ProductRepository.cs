using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Admin.Models;
using Admin.IRepository;
using Admin.Dtos;

namespace Admin.Repository
{
    public class ProductRepository : IProductrepository
    {
        private ApplicationDbContext db;
        private ProductRepository() { }
        public ProductRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public Product Add(Product model)
        {
            db.Products.Add(model);
            db.SaveChanges();
            Dispose();
            return model;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = db.Products.Include(c => c.Category).ToList();
            return products;
        }

        public Product GetProductById(int Id)
        {
            var productById = db.Products
                .Where(p=>p.ProductId == Id)
                .Include(p => p.Category)
                .FirstOrDefault();
            return productById;
        }

        public void DisableProduct(int Id)
        {
            var product = db.Products.Where(p => p.ProductId == Id).FirstOrDefault();
            product.DisplayStatus = false;
            db.Products.Attach(product);
            db.Entry<Product>(product).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EnableProduct(int Id)
        {
            var product = db.Products.Where(p => p.ProductId == Id).FirstOrDefault();
            product.DisplayStatus = true;
            db.Products.Attach(product);
            db.Entry<Product>(product).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Product Update(Product modelToUpdate)
        {
            db.Products.Attach(modelToUpdate);
            db.Entry<Product>(modelToUpdate).State = EntityState.Modified;
            db.SaveChanges();
            return modelToUpdate;
        }

        public IEnumerable<DisplayStatus> GetDisplayStatus()
        {
            return db.DisplayStatus.ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}