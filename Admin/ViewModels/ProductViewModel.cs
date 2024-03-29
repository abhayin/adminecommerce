﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Admin.Dtos;
using Admin.Models;

namespace Admin.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            CategoryDropdown = new HashSet<CategoryDto>();
            StatusDropdown = new HashSet<DisplayStatus>();
            TagsDropdown = new HashSet<TagDto>();
        }
        public IEnumerable<CategoryDto> CategoryDropdown { get; set; }
        public IEnumerable<DisplayStatus> StatusDropdown { get; set; }
        public IEnumerable<TagDto> TagsDropdown { get; set; }
        public ProductDto ProductDto { get; set; }
    }
}