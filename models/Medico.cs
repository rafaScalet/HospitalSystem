using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class Medico : Pessoa
    {
        public string Especialidade { get; set; }
        public string CRM { get; set; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nEspecialidade: " + Especialidade + "\nCRM: " + CRM;
        }   
    }
}