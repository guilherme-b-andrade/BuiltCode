using BuiltCodeTest.Domain.Contracts;
using BuiltCodeTest.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuiltCodeTest.Web.Controllers
{
    [Route("api/[Controller]")]
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }       
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_doctorRepository.GetAll());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        public IActionResult Save([FromBody]Doctor doctor)
        {
            try
            {
               
                _doctorRepository.Save(doctor);

                return Created("api/doctor",doctor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
