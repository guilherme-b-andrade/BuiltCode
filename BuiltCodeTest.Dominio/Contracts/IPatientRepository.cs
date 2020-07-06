using BuiltCodeTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltCodeTest.Domain.Contracts
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {
        List<Patient> GetPatient(int idDoctor);

    }
}
