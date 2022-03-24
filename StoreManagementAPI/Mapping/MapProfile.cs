using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagementAPI.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Personnel, PersonnelForLoginDto>();
            CreateMap<PersonnelForLoginDto, Personnel>();

            CreateMap<Personnel, PersonnelForRegisterDto>();
            CreateMap<PersonnelForRegisterDto, Personnel>();
        }
    }
}
