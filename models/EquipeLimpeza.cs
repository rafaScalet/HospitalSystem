using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public sealed class EquipeLimpeza : Pessoa
    {
        private string setor;
        private string funcao;

        public EquipeLimpeza()
        {
        }

        public EquipeLimpeza(string setor, string funcao)
        {
            this.setor = setor;
            this.funcao = funcao;
        }

        public string Setor { get => setor; set => setor = value; }
        public string Funcao { get => funcao; set => funcao = value; }

        public override string show()
        {
            return "\nNome: " + Nome + "\nSexo: " + Sexo + "\nIdade: " + Idade + "\nSetor: " + Setor + "\nFunção: " + Funcao;
        }
    }
}