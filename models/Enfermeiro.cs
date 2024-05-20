using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class Enfermeiro : Pessoa
    {
        public string AreaAtuacao { get; set; }
        public string Coren { get; set; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nArea Atuação: " + AreaAtuacao + "\nCoren: " + Coren;
        }
    }
}