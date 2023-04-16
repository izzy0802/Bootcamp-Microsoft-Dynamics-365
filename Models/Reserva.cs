using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
         public Reserva (int diasReservados){
            DiasReservados = diasReservados;
        }
        
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if(Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A quantidade de hospedes é maior que a capacidade da suite. ");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return  Hospedes.Count;
        } 

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10 )
            {
                decimal porcentual = 10 / 100;
                decimal valorAtual = valor - (porcentual * valor);

                return valorAtual;
            }
            return valor;
        }
    }
}