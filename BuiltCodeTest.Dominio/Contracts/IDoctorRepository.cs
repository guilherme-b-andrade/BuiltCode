using BuiltCodeTest.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BuiltCodeTest.Domain.Contracts
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {   
        /// <summary>
        /// Get doctor filtering by Id
        /// </summary>
        /// <param name="crm"></param>
        /// <returns></returns>
        Doctor GetByCrm(string crm);

        /// <summary>
        /// Get Patient filtering by doctorId
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        List<Patient> GetPatient(int doctorId);

    }
}
