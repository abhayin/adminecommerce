using Admin.Dtos;
using Admin.IRepository;
using Admin.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext db;
        private CategoryRepository() { }
        public CategoryRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<CategoryDto> GetCategories()
        {
            var categories = db.Categories.ToList().Select(Mapper.Map<Category,CategoryDto>);
            Dispose();
            return categories.ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}