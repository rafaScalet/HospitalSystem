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

        private string Nome { get; set; }
        private string Sexo { get; set; }
        private int Idade { get; set; }

        public abstract string show();
    }
}