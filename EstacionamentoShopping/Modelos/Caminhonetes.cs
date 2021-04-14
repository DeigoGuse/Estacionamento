using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public class Caminhonetes : Veiculo
    {
        public Caminhonetes(string placa,bool estacionado,int quantidadeDeUso)
            : base(placa, estacionado, quantidadeDeUso)
        {
        }

        public override string Categoria()
            => "Caminhonete";

    }
}
