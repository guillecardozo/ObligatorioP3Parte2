using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public interface IManejadorUsuario
    {
        IEnumerable<Usuario> TodosLosUsuarios();

        public Usuario LogIn(string nombre, string contra);
    }
}
