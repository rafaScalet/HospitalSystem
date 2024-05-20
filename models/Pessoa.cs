using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.models
{
    public abstract class Pessoa
    {
        protected Pessoa()
        {
        }

        protected Pessoa(string nome, string sexo, int idade)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }

        protected string Nome { get; set; }
        protected string Sexo { get; set; }
        protected int Idade { get; set; }

        public abstract string show();
    }
}