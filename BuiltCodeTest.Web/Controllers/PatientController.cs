
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

                var patientCpf = _patientRepository.GetPatient(patient.Cpf).Cpf;

                if (!string.IsNullOrEmpty(patientCpf))
                {

                    return BadRequest("CPF já está cadastrado no sistema");

                }

                if (patient.Id > 0)
                {
                    _patientRepository.Put(patient);
                }
                else
                {
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

                _patientRepository.Remove(patient);

                return Json(_patientRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("FilterByDoctorId/{doctorId}")]
        public IActionResult FilterByDoctorId(int doctorId)
        {
            try
            {
                if (string.IsNullOrEmpty(doctorId.ToString()))
                {

                    return Json(_patientRepository.GetAll());

                }

                var patients = _patientRepository.GetPatient(doctorId);

                if (patients.Count == 0)
                {

                    return BadRequest($"O médico não tem nenhum paciente vinculado.");
                }


                return Json(patients);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
