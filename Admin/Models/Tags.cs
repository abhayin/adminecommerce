using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class Tags
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public bool IsDeleted { get; set; }
        public Product Product { get; set; }
    }
}