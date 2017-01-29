﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
        [AllowHtml]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Weight { get; set; }
        public int MyProperty { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool Enabled { get; set; }
    }
}