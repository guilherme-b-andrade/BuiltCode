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

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddWarning("O Nome do médico não foi informado");

            if (string.IsNullOrEmpty(Crm))
                AddWarning("O Crm do médico não foi informado");

            if (string.IsNullOrEmpty(CrmUf))
                AddWarning("O CrmUf do médico não foi informado");

        }

    }
}
