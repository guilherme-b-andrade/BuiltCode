using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltCodeTest.Domain.Entities
{
    public class Patient : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
         public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (DoctorId != 0)
            {
                AddWarning("Cuidado: É necessário vincular um médico ao Paciente");
           
            }
            if (string.IsNullOrEmpty(Cpf)){

                AddWarning("Cuidado: O CPF precisa ser peenchido");
            }
        }
    }
}
