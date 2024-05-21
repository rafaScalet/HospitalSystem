using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class Medico : Pessoa
    {
        private string especialidade;
        private string crm;

        public Medico()
        {
        }

        public Medico(string especialidade, string crm)
        {
            this.especialidade = especialidade;
            this.crm = crm;
        }

        public string Especialidade { get => especialidade; set => especialidade = value; }
        public string Crm { get => crm; set => crm = value; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nEspecialidade: " + Especialidade + "\nCRM: " + Crm;
        }   
    }
}