using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;
using System.Linq;

namespace Repositorios
{
    public class RepoFichaCuidadosEF : IRepositorioFichaCuidados
    {
        public LibreriaContext Contexto { get; set; }

        public RepoFichaCuidadosEF(LibreriaContext ctx)
        {
            Contexto = ctx;
        }

        public bool Add(FichaCuidados obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FichaCuidados> FindAll()
        {
            throw new NotImplementedException();
        }

        public FichaCuidados FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(FichaCuidados obj)
        {
            throw new NotImplementedException();
        }
    }
}
