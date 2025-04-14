using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospedagem.Models;

namespace Hospedagem.Models
{
    public class Reserva
    {
         public List<Pessoa> Hospedes { get; set; }
         public Suite suite { get; set; }
         public int DiasReservados {get; set;}

         public Reserva(){
            this.Hospedes = new List<Pessoa>();
            this.suite = new Suite();
            this.DiasReservados = 0;
         }

         public Reserva(int diasReservados){
            this.DiasReservados = diasReservados;
            this.Hospedes = new List<Pessoa>();
            this.suite = new Suite();
         }

         public void CadastrarHospedes(List<Pessoa> hospedes){
            if(suite.Capacidade >= hospedes.Count()){
                foreach (Pessoa pessoa in hospedes)
                {
                    Hospedes.Add(pessoa);    
                }
            }else{
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suite!");
            }
            
         }

         public void CadastrarSuite(Suite suite){
            this.suite = suite;
         }

        public int ObterQuantidadeHospedes(){
            int qtde = 0; 
            foreach (Pessoa pessoa in Hospedes)
            {
                qtde = qtde + 1;
            }
            return qtde;
        }

        public decimal CalcularValorDiaria(){
            decimal valor =  DiasReservados * (suite.ValorDiaria);

            if (DiasReservados >= 10) {   
                valor = (valor - (valor * 10 /100));
                return valor;
            }
            else
            {
                return valor;    
            }    
        }

    }
}