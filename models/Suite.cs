using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOSPEDAGEM_DE_HOTEL.models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria )
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}