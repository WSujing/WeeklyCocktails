using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CocktailMVC.Dtos;

namespace CocktailMVC.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cocktail, CocktailDto>();
            CreateMap<Theme, ThemeDto>();

            CreateMap<CocktailForPostDto, Cocktail>();

        }
    }
}