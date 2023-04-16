using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome = "";
        private string _sobrenome = "";
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if( value == "")
                {
                    throw new ArgumentException("O nome não pode estar vazio.");
                }
            }
        }

        public string Sobrenome
        {
            get
            {
                return _sobrenome.ToUpper();
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O sobresnome não pode estar vazio.");
                }
            }
     
        }
    }
}