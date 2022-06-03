using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;
using System.Linq;

namespace Repositorios
{
    public class RepoCompraEF : IRepositorioCompra
    {
        public LibreriaContext Contexto { get; set; }

        public RepoCompraEF(LibreriaContext ctx)
        {
            Contexto = ctx;
        }

        public bool Add(Compra obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compra> FindAll()
        {
            throw new NotImplementedException();
        }

        public Compra FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Compra obj)
        {
            throw new NotImplementedException();
        }
    }
}
