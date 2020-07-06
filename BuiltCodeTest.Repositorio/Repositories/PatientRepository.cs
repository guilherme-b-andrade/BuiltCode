using BuiltCodeTest.Domain.Contracts;
using BuiltCodeTest.Domain.Entities;
using BuiltCodeTest.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltCodeTest.Repository.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(BuiltCodeTestContext builtCodeTestContext) : base(builtCodeTestContext)
        {

           
        }

        public List<Patient> GetPatient(int doctorId)
        {
            var patient = (from p in BuiltCodeTestContext.Patients
                           where p.DoctorId == doctorId
                           select p).ToList();
            return patient;
        }
    }
}
