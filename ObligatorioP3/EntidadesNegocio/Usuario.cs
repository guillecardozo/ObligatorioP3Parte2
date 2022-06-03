using ObligatorioP3.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class Usuario
    {
        #region Propiedades
        public int Id { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [MinLength(6)]
        [Required]
        public string Password { get; set; }
        public string Rol { get; set; }
        
        public List<CompraUsuario> ComprasUsuarios { get; set; }

        #endregion
    }

}
