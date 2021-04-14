using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public class Motocicleta : Veiculo
    {
        public Motocicleta(string placa,bool estacionado,int quantidadeDeUso)
            : base(placa,estacionado, quantidadeDeUso)
        {
        }

        public override string Categoria()
           =>  "Motocicleta";
           
    }
}
