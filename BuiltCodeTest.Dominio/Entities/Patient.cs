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

            if (String.IsNullOrEmpty(Name))
            {
                AddWarning("O Nome precisa ser preenchido");

            }

            if (BirthDate == Convert.ToDateTime(null))
            {
                AddWarning("A data de nascimento precisa ser preenchida");

            }

            if (DoctorId == 0)
            {
                AddWarning("É necessário vincular um médico ao Paciente");

            }
            if (string.IsNullOrEmpty(Cpf))
            {
                AddWarning("O CPF precisa ser peenchido");
            }
            else if (Cpf.Length > 11 || Cpf.Length < 11)
            {

                AddWarning("O CPF está inválido");
            }

        }
    }
}
