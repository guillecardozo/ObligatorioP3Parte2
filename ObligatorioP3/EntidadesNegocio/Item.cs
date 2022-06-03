using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class Item
    {
        #region Propiedades

        public int Id { get; set; }
        public Planta Planta { get; set; }

        public int PlantaId { get; set; }
        public Compra Compra { get; set; }

        public int CompraId { get; set; }
       
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        #endregion

        #region Metodos
        public decimal Subtotal()
        {
            decimal valor = Cantidad * PrecioUnitario;
            return valor;
        }
        #endregion
    }
}
