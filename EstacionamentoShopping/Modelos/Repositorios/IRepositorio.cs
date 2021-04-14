using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public interface IRepositorio<T> 
    {
        void Insert(T obj);
        List<T> ConsultarTodos();
     

    }
}
