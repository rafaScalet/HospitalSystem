using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class Paciente : Pessoa
    {
        private string numeroProntuario;
        private string diagnostico;

        public Paciente()
        {
        }

        public Paciente(string numeroProntuario, string diagnostico)
        {
            this.numeroProntuario = numeroProntuario;
            this.diagnostico = diagnostico;
        }

        public string NumeroProntuario { get => numeroProntuario; set => numeroProntuario = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nNúmero do Prontuário: " + NumeroProntuario + "\nDiagnóstico: " + Diagnostico;
        }
    }
}