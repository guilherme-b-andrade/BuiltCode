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
        public IActionResult GetAll()
        {
            try
            {
                var doctors = _doctorRepository.GetAll();
                return Json(doctors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }



        [HttpPost]
        public IActionResult Save([FromBody] Doctor doctor)
        {
            try
            {
                doctor.Validate();
                if (!doctor.IsValid)
                {
                    return BadRequest(doctor.GetValidateMessage());

                }
                if (doctor.Id > 0)
                {
                    _doctorRepository.Put(doctor);
                }
                else
                {
                    var existCrm = _doctorRepository.GetByCrm(doctor.Crm);

                    if (existCrm != null)
                    {
                        return BadRequest("Médico já cadastrado no sistema");
                    }
                    _doctorRepository.Save(doctor);
                }


                return Created("api/doctor", doctor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
         
        }


        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] Doctor doctor)
        {
            try
            {

                var patients = _doctorRepository.GetPatient(doctor.Id);

                if (patients.Count > 0)
                {
                    return BadRequest("Não é possível fazer a exclusão. O Médico tem um paciente vinculado ");
                }

                _doctorRepository.Remove(doctor);


                return Json(_doctorRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
      
    }
}
