

using BuiltCodeTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuiltCodeTest.Repository.Config
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.BirthDate)
                .IsRequired();

            builder.Property(d => d.Cpf)
                .IsRequired();

            builder.Property(d => d.DoctorId)
                .IsRequired();
        }
    }
}
