using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class Tasas
    {
        #region Propiedades
        public int Id { get; set; }
        public decimal TasaImportacion { get; set; }
        public decimal TasaIva { get; set; }

        public decimal TasaArancelaria { get; set; }

        public List<Compra> Compras { get; set; }


        #endregion
    }
}