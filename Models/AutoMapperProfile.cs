using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperDemo.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentDTO, Student>()
            .ForMember(x => x.City, y => y.MapFrom(z => z.CurrentCity));
            CreateMap<AddressDTO, Address>();
        }
    }
}
