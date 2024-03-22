using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Dtos;
using Application.Features.Cars.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, CreateCarResponse>().ReverseMap();
            CreateMap<Car, GetListCarResponse>()
                .ForMember(destinationMember: x => x.BrandName, memberOptions: opt => opt.MapFrom(x => x.Model.Brand.Name));
            CreateMap<IPaginate<Car>, CarListModel>().ReverseMap();
        }
    }
}
