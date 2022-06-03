using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class FichaCuidados
    {
        #region Propiedades
        public int Id { get; set; }
        public string FrecuenciaRiego { get; set; }
        public string TipoIluminacion { get; set; }
        public decimal Temperatura { get; set; }

        public List<Planta> Plantas { get; set; }

        #endregion
    }
}
