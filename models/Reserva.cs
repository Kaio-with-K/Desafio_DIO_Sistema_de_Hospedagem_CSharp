using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOSPEDAGEM_DE_HOTEL.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
            
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes (List <Pessoa> hospedes) {
            if(hospedes.Count < Suite.Capacidade) {
                Hospedes = hospedes;
            }
            else {
                throw new Exception("Valor maior");
            }
        } 
        public void CadastrarSuite(Suite suite) {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() {
            foreach(Pessoa hospedes in Hospedes) {
                Console.WriteLine(hospedes);
            }
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10) {
                valor = valor - (valor * 10 / 100);
            }

            return valor;
        }
    }
}