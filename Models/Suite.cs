using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        private string _tipoSuite = "";
        private int _capacidade = 0;
        private decimal _valorDiaria = 0;

        public string TipoSuite
        {
            get
            {
                return _tipoSuite.ToUpper();
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O tipo de suite não pode estar vazio");
                }
            }
        }

        public int Capacidade { get; set; }

        public decimal ValorDiaria { get; set; }
    }
}