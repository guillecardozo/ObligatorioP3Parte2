using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;
using System.Linq;

namespace Repositorios
{
    public class RepoUsuarioEF : IRepositorioUsuario
    {
        public LibreriaContext Contexto { get; set; }

        public RepoUsuarioEF(LibreriaContext ctx)
        {
            Contexto = ctx;
        }

        public bool Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario LogIn(string mail, string contra)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionContrasenia(string contrasenia)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionEmail(string mail)
        {
            throw new NotImplementedException();
        }
    }
}
