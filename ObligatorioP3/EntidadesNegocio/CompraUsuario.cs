using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class CompraUsuario
    {
        #region Propiedades
        public int Id { get; set; }
        
        public Compra Compra { get; set; }

        public int CompraId { get; set; }

        public Usuario Usuario { get; set; }

        public int UsuarioId { get; set; }
        #endregion
    }
}
