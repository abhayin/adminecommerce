using Admin.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.IRepository
{
    interface ICategoryRepository : IDisposable
    {
        IEnumerable<CategoryDto> GetCategories();
    }
}
