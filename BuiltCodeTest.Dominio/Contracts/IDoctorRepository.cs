using BuiltCodeTest.Domain.Entities;
using System;



namespace BuiltCodeTest.Domain.Contracts
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        Doctor GetByCrm(string crm);

    }
}
