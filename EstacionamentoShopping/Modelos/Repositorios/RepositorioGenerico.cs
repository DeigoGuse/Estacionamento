using EstacionamentoShopping.Modelos.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstacionamentoShopping
{
    public abstract class RepositorioGenerico<T> : IRepositorio<T>
    {
        private List<T> listaGenerica;

        public RepositorioGenerico()
        {
            listaGenerica = new List<T>();
        }

        public void Insert(T obj)
        {
            if (!listaGenerica.Contains(obj))
            {
              
                listaGenerica.Add(obj);
            }

        }


        public List<T> ConsultarTodos()
         => listaGenerica;

        
    }
}

