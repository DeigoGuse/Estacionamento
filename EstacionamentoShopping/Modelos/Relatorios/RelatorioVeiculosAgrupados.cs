using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstacionamentoShopping
{
    public class RelatorioVeiculosAgrupados : IRelatorio
    {
        private RepositorioVeiculos repositorioDeVeiculos;

        public RelatorioVeiculosAgrupados(RepositorioVeiculos repositorioDeVeiculos)
        {
            this.repositorioDeVeiculos = repositorioDeVeiculos;

        }

        public void GerarRelatorio()
        {

            var listaOrdenada = repositorioDeVeiculos.ConsultarTodos()
                .OrderBy(x => x.Placa).ToList();


            var listaAgrupada = listaOrdenada.OrderBy(x => x.GetType().Name);


            foreach (var grupo in listaAgrupada)
            {
                Console.WriteLine(" Categoria : " + grupo.Categoria());

                foreach (var veiculo in listaAgrupada)
                {
                    Console.WriteLine("\n---------------\n");
                    Console.WriteLine("Placa Veiculo : " + veiculo.Placa);
                    Console.WriteLine("Entrada Veiculo : " + veiculo.Placa);
                    Console.WriteLine("Saida Veiculo : " + veiculo.Placa);
                    Console.WriteLine("\n---------------\n");

                }

            }



        }
    }
}
