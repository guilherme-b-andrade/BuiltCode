using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltCodeTest.Dominio.Entities
{
    class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Crm { get; set; }
        public string CrmUf { get; set; }
        //public ICollection<Patient> ListPatient { get; set; }
    }
}
