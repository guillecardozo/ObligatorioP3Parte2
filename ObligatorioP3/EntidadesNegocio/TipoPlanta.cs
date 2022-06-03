using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class TipoPlanta
    {
        #region Propiedades
        public int Id { get; set; }
       
        [Required]
        public string Nombre { get; set; }

        [MaxLength(200)]
        [MinLength(10)]
        public string Descripcion { get; set; }

        public List<Planta> Plantas { get; set; }

        //public int PlantasId { get; set; }
        #endregion
    }
}
