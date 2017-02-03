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
        IEnumerable<DisplayStatus> GetDisplayStatus();
        void EnableProduct(int Id);
        void DisableProduct(int Id);
    }
}
