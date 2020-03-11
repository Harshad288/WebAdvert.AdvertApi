using AdvertApi.Models;
using AdvertApi.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AdvertModel, AdvertDbModel>();
        }
    }
}
