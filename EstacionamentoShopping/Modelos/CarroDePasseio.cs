using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public class CarroDePasseio : Veiculo
    {
        public CarroDePasseio(string placa,bool estacionado,int quantidadeDeUso)
            : base(placa,estacionado, quantidadeDeUso)
        {
        }

        public override string Categoria()
            => "Carro de Passeio";
    }
}
