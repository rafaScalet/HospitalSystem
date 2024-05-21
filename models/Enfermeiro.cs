using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class Enfermeiro : Pessoa
    {
        private string areaAtuacao;
        private string coren;

        public Enfermeiro()
        {
        }

        public Enfermeiro(string areaAtuacao, string coren)
        {
            this.areaAtuacao = areaAtuacao;
            this.coren = coren;
        }

        public string AreaAtuacao { get => areaAtuacao; set => areaAtuacao = value; }
        public string Coren { get => coren; set => coren = value; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nArea Atuação: " + AreaAtuacao + "\nCoren: " + Coren;
        }
    }
}