using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutomapperDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public Student Get()
        {
            StudentDTO studentDTO = new StudentDTO()
            {
                Name = "Hiren Prajapati",
                Age = 25,
                CurrentCity = "Ahmedabad",
                //Address =
                //{
                //    Country = "India",
                //    State="Gujrat"
                //}

            };

            return _mapper.Map<Student>(studentDTO);
        }

    }
}