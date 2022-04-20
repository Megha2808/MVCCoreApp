using AutoMapper;
using System;
using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.DomainModels.Models;

namespace TestMVC.Core.MapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateAgreeMentModuleMapper();
            CreateProductGroupMapper();
            CreateProductMapper();

        }
        void CreateAgreeMentModuleMapper()
        {
            CreateMap<Agreement, AgreementAc>()
                        .ForMember(x => x.ProductNumber, opts => opts.MapFrom(
                        src => src.Product != null ? src.Product.ProductNumber : Guid.Empty))
                         .ForMember(x => x.ProductPrice, opts => opts.MapFrom(
                        src => src.Product != null ? src.Product.Price : 0))
                         .ForMember(x => x.ProductDescription, opts => opts.MapFrom(
                       src => src.Product != null ? src.Product.ProductDescription : string.Empty))
                 .ForMember(x => x.ProductGroupCode, opts => opts.MapFrom(
                 src => src.ProductGroup != null ? src.ProductGroup.GroupCode : Guid.Empty))
                    .ForMember(x => x.GroupDescription, opts => opts.MapFrom(
                 src => src.ProductGroup != null ? src.ProductGroup.GroupDescription : string.Empty))
                 .ReverseMap();
        }
        void CreateProductGroupMapper()
        {
            CreateMap<ProductGroup, ProductGroupAc>()
                 .ReverseMap();
        }
        void CreateProductMapper()
        {
            CreateMap<Product, ProductAc>()
                 .ReverseMap();
        }
    }
}