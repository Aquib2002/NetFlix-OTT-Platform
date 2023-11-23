using AutoMapper;
using NetFlix.Models;
using NetFlix.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlix.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Coustomer, CoustomerDto>();

            Mapper.CreateMap<CoustomerDto, Coustomer>();

        }
    }
}