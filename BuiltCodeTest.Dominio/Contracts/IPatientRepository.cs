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


        /// <summary>
        /// Get Patient filtering by CPF
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        Patient GetPatient(string cpf);

    }
}
