using AmCart.ProductModule.AppServices.DTOs;
using AmCart.ProductModule.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.ProductModule.AppServices.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() : base("MappingProfile")
        {
           // CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
