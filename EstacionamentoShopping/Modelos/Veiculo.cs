using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public abstract class Veiculo 
    {
        

        public String Placa { get; private set; }
        public bool Estacionado { get; set; }
        public int QuantidadeDeUso { get; set; }

        

        protected Veiculo(string placa,bool estacionado, int quantidadeDeUso)
        {
            Placa = placa;
            Estacionado = estacionado;
            QuantidadeDeUso = quantidadeDeUso;
           
        }

        public abstract string Categoria();


    }
}
