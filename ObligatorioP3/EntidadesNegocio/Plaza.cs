using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class Plaza : Compra
    {
        #region Propiedades
        public decimal CostoFlete { get; set; }
        //public Tasas TasaIva { get; set; }

        #endregion

        #region Metodos
        public override string Tipo()
        {
            return "Plaza";
        }
        public override decimal CalcularCosto()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
