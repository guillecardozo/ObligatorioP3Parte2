using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.EntidadesNegocio
{
    public class Planta
    {
        #region Propiedades
        public int Id { get; set; }

        [Required]
        public string NombreCientifico { get; set; }
        public string NombreVulgar { get; set; }

        [MinLength(10)]
        [MaxLength(500)]
        public string Descripcion { get; set; }
        public string TipoAmbiente { get; set; }
        public decimal Altura { get; set; }

        [Required]
        public string Foto { get; set; }
        public decimal Precio { get; set; }
       
        public FichaCuidados FichaCuidados { get; set; }

        public TipoPlanta TipoPlanta { get; set; }

        //public int TipoPlantaId { get; set; }

        public List<Item> Items { get; set; }

        //public int ItemId { get; set; }
        #endregion
    }
}
