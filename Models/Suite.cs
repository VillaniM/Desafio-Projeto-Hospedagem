using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Suite
    {
        public string TipoSuite { get; set;}
        public int Capacidade { get; set;}
        public decimal ValorDiaria { get; set;}
        public Suite(){
            TipoSuite = "";
            Capacidade = 0;
            ValorDiaria = 0;
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria){
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
        }
    }
}