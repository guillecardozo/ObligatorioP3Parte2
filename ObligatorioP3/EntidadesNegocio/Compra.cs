using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public abstract class Compra
    {
        #region Propiedades
        public int Id { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Cantidad { get; set; }
        public List<Item> Items { get; set; }

        //public int ItemId { get; set; }

        public Tasas Tasas { get; set; }

        public List<CompraUsuario> ComprasUsuarios { get; set; }

        //public int CompraUsuarioId { get; set; }

        #endregion

        #region Metodos
        public abstract string Tipo(); //Metodo para realizar override en las clases Plaza, Importacion.
        public abstract decimal CalcularCosto();
        #endregion
    }
}
