using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class Paciente : Pessoa
    {
        public string NumeroProntuario { get; set; }
        public string Diagnostico { get; set; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nNúmero do Prontuário: " + NumeroProntuario + "\nDiagnóstico: " + Diagnostico;
        }
    }
}