
using BuiltCodeTest.Domain.Contracts;
using BuiltCodeTest.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;



namespace BuiltCodeTest.Web.Controllers
{
    [Route("api/[Controller]")]
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Json(_patientRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        [HttpPost]
        public IActionResult Save([FromBody] Patient patient)
        {
            try
            {
          
                patient.Validate();
                if (!patient.IsValid)
                {
                    return BadRequest(patient.GetValidateMessage());

                }
                if (patient.Id > 0)
                {
                    _patientRepository.Put(patient);
                }
                else
                {
                    //var existCrm = _patientRepository.GetByCrm(patient.Crm);

                    //if (existCrm != null)
                    //{
                    //    return BadRequest("Médico já cadastrado no sistema");
                    //}
                    _patientRepository.Save(patient);
                }


                return Created("api/patient", patient);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] Patient patient)
        {
            try
            {

               
                //var id = patient.Id;
                //var existPatient = _patientRepository.GetById(id).Patients;

                //if(existPatient.Count > 0)
                //{
                //    return BadRequest("Não é possível remover o médico, pois existe um paciente vínculado");
                //}

                _patientRepository.Remove(patient);


                return Json(_patientRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
