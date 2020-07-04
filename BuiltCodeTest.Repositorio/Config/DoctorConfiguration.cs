using BuiltCodeTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltCodeTest.Repository.Config
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Crm)
                .IsRequired();

            builder.Property(d => d.CrmUf)
                .IsRequired();

            builder.HasMany(d => d.Patients)
                .WithOne(p => p.Doctor);
            //builder.HasKey()
        }
    }
}
