using BuiltCodeTest.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BuiltCodeTest.Domain.Contracts
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        Doctor GetByCrm(string crm);

        List<Patient> GetPatient(int idDoctor);

    }
}
