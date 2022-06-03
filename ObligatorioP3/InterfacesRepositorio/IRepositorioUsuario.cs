using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace ObligatorioP3.InterfacesRepositorio
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        public Usuario LogIn(string mail, string contra);

        bool ValidacionContrasenia(string contrasenia);

        bool ValidacionEmail(string mail);
    }
}
