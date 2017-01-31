using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Enabled { get; set; }
    }
}