using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EstacionamentoShopping
{
    public class RelatorioTodosVeiculos : IRelatorio
    {
        private RepositorioVeiculos repositorioDeVeiculos;
        
        public RelatorioTodosVeiculos(RepositorioVeiculos repositorioDeVeiculos)
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

                foreach  (var veiculo in listaAgrupada)
                {
                    Console.WriteLine("\n---------------\n");
                    Console.WriteLine("Placa Veiculo : " + veiculo.Placa);
                    Console.WriteLine("Entrada Veiculo : " + veiculo.Categoria());
                    Console.WriteLine("Saida Veiculo : " + veiculo.Estacionado);
                    Console.WriteLine("\n---------------\n");

                }

            }
           
           

        }
    }
}
