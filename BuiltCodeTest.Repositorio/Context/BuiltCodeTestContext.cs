
using BuiltCodeTest.Domain.Entities;
using BuiltCodeTest.Repository.Config;
using Microsoft.EntityFrameworkCore;

namespace BuiltCodeTest.Repository.Context
{
    public class BuiltCodeTestContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public BuiltCodeTestContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
