using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.IRepository
{
    public interface IProductrepository : IDisposable
    {
        Product Add(Product model);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int Id);
    }
}
