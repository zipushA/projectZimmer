using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
           CreateMap<Cleaner,DtoCleanersGet>().ReverseMap();
            CreateMap<Cleaner, DtoCleanersPost>().ReverseMap();
            CreateMap<Owner, DtoOwnerGet>().ReverseMap();
            CreateMap<Owner, DtoOwnerPost>().ReverseMap();
            CreateMap<Zimmer, DtoZimmer>().ReverseMap();
        }
    }
}
