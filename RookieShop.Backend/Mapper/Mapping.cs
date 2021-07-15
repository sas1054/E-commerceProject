using AutoMapper;
using RookieShop.Backend.Models;
using RookieShop.Shared.DTOs;
using RookieShop.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieShop.Backend.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTORequest>().ReverseMap();
            CreateMap<Product, ProductDTOResponse>().ReverseMap();
        }
    }
}
