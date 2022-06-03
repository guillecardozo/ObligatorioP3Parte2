using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace ObligatorioP3.InterfacesRepositorio
{
   public interface IRepositorioPlanta : IRepositorio<Planta>
    {
        public Planta BuscarPlantaPorNombreVulgar(string nombre);
        public List<Planta> ListaDePlantasPorNombre(string nombre);
        public List<Planta> ListaDePlantasSegunTipos(int Id);
        public List<Planta> ListaSegunAmbiente(string ambiente);
        public List<Planta> ListaSegunAlturaBaja(int altura);
        public List<Planta> ListaSegunAlturaAlta(int altura);
    }
}
