﻿using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Dtos;
using Application.Features.Brands.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, CreateBrandResponse>().ReverseMap();
            CreateMap<Brand, GetListBrandResponse>().ReverseMap();
            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
        }
    }
}
