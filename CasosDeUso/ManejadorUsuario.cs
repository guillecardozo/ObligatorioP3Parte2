using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public class ManejadorUsuario : IManejadorUsuario
    {
        public IRepositorioUsuario RepoUsuario { get; set; }

        public ManejadorUsuario(IRepositorioUsuario repo)
        {
            RepoUsuario = repo;
        }

        public IEnumerable<Usuario> TodosLosUsuarios()
        {
            return RepoUsuario.FindAll();
        }

        public Usuario LogIn(string nombre, string contra)
        {
            return RepoUsuario.LogIn(nombre, contra);
        }
    }
}
