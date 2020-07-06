using BuiltCodeTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltCodeTest.Domain.Contracts
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {

        /// <summary>
        /// Get Patient filtering by doctorId
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        List<Patient> GetPatient(int doctorId);


        Patient GetPatient(string cpf);

    }
}
