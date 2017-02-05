using Admin.Dtos;
using Admin.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ProductDto, Product>();
            Mapper.CreateMap<Product, ProductDto>();
            Mapper.CreateMap<Category, CategoryDto>();
            Mapper.CreateMap<CategoryDto, Category>();
            Mapper.CreateMap<Tags, TagDto>();
            Mapper.CreateMap<TagDto, Tags>();

        }
    }
}