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
        }
    }
}