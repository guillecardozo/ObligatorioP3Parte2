using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioP3.EntidadesNegocio;
using Microsoft.AspNetCore.Http;
using CasosDeUso;

namespace WebMVC.Models
{
    public class ViewModelPlanta
    {
        public Planta Planta { get; set; }
        public IEnumerable<TipoPlanta> TipoPlanta { get; set; }
        public IEnumerable<FichaCuidados> FichaCuidados { get; set; }
        public IFormFile Imagen { get; set; }
        public int IdTipoPlantaSeleccionada { get; set; }
        public int IdFichaCuidadoSeleccionada { get; set; }
    }
}
