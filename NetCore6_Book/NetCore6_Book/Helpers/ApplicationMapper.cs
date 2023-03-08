using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetCore6_Book.Data;
using NetCore6_Book.Models;

namespace NetCore6_Book.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
        }
    }
}
