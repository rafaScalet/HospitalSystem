using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public abstract class Pessoa
    {
        private string nome;
        private string sexo;
        private int idade;

        protected Pessoa()
        {
        }

        protected Pessoa(string nome, string sexo, int idade)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }

        public abstract string show();
    }
}