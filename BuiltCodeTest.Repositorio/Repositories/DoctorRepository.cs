using BuiltCodeTest.Domain.Contracts;
using BuiltCodeTest.Domain.Entities;
using BuiltCodeTest.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltCodeTest.Repository.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(BuiltCodeTestContext builtCodeTestContext) : base(builtCodeTestContext)
        {
        }
    }
}
