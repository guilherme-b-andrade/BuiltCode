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
        public string Crm { get; set; }
        public string CrmUf { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        public override void Validate()
        {
            throw new NotImplementedException();
        }
       
    }
}
