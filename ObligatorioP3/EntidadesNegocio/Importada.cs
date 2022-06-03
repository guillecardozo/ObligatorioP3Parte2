using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class Importada : Compra
    {
        #region Propiedades
        public bool ContinenteOrigen { get; set; }
        public string MedidasSanitarias { get; set; }
        //public Tasas TasaImportacion { get; set; }

        //public Tasas TasaArancelaria { get; set; }


        #endregion

        #region Metodos
        public override string Tipo()
        {
            return "Importado";
        }

        public override decimal CalcularCosto()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
