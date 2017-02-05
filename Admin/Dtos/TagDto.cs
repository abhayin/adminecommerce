using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Dtos
{
    public class TagDto
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public bool IsDeleted { get; set; }
    }
}