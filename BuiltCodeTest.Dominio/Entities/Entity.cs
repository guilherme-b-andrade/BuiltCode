using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltCodeTest.Domain.Entities
{
    public abstract class Entity
    {

        private List<string> _validationMessage { get; set; }

        private List<string> ValidationMessage
        {
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }

        protected void ClearValidationMessage()
        {
            ValidationMessage.Clear();
        }
        protected void AddWarning(string mensagem)
        {
            ValidationMessage.Add(mensagem);
        }

        public abstract void Validate();

        protected bool IsValid
        {
            get { return !ValidationMessage.Any(); }
        }
    }
}
