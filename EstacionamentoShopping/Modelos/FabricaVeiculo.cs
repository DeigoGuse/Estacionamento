using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public class FabricaVeiculo
    {
        public static Veiculo Cria(string placa,bool estacionado, int quantidadeDeUso, EnumTipoVeiculo enumTipoVeiculo)
        {
            Veiculo veiculo = null;

            switch (enumTipoVeiculo)
            {
                case EnumTipoVeiculo.MOTOCICLETA:
                    veiculo = new Motocicleta(placa,estacionado, quantidadeDeUso);
                    break;
                case EnumTipoVeiculo.CARRO:
                    veiculo = new CarroDePasseio(placa,estacionado, quantidadeDeUso);
                    break;
                case EnumTipoVeiculo.CAMINHONETE:
                    veiculo = new Caminhonetes(placa,estacionado, quantidadeDeUso);
                    break;
                default:
                    throw new ArgumentException("Tipo de Veiculo não encontrado");
            }

            return veiculo;



        }
    }
}
