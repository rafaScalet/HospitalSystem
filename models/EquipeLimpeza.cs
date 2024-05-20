using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class EquipeLimpeza : Pessoa
    {
        public string Setor { get; set; }
        public string Funcao { get; set; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nSetor: " + Setor + "\nFunção: " + Funcao;
        }
    }
}