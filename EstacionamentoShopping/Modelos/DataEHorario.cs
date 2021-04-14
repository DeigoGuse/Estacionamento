using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping.Modelos.Calculo
{
    public class DataEHorario 
    {
        public string Placa { get; set; }
       
        public DateTime DataEntrada { get; set; }

        public DateTime DataSaida { get; set; }

        public DataEHorario(string placa, DateTime dataEntrada, DateTime dataSaida)
        {
            Placa = placa;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }
    }
}
