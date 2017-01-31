using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Admin.Dtos;

namespace Admin.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<CategoryDto> CategoryDropdown { get; set; }
        public ProductDto ProductDto { get; set; }
    }
}