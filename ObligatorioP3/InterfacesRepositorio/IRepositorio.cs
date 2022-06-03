using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;

namespace ObligatorioP3.InterfacesRepositorio
{
    public interface IRepositorio<T> where T:class
    {
        bool Add(T obj);
        bool Remove(int id);
        bool Update(T obj);
        IEnumerable<T> FindAll();
        T FindById(int id);
    }
}
