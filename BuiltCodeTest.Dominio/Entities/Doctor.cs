using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BuiltCodeTest.Domain.Entities
{
    public class Doctor : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Crm { get; set; }
        public string CrmUf { get; set; }

        //public virtual ICollection<Patient> Patients { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddWarning("Nome do médico não foi informado");

            if (string.IsNullOrEmpty(Crm))
                AddWarning("Crm do médico não foi informado");

            if (string.IsNullOrEmpty(CrmUf))
                AddWarning("CrmUf do médico não foi informado");

        }
       
    }
}
