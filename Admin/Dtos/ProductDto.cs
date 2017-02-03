using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        [Display(Name="Product Name")]
        public string ProductName { get; set; }

        [AllowHtml]
        public string Description { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "Discount Price")]
        public decimal DiscountPrice { get; set; }
        public decimal Weight { get; set; }
        
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public bool DisplayStatus { get; set; }
    }
}