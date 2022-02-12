using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Services.ViewModels;

namespace TodoApi.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorViewModel>()
                .ForMember(dest=> dest.Address,
                opt=> opt.MapFrom(src => $"{src.AddressNo}, {src.Street},{src.City}"));
        }
    }
}
