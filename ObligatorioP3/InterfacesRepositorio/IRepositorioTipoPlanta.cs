using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;


namespace ObligatorioP3.InterfacesRepositorio
{
    public interface IRepositorioTipoPlanta : IRepositorio<TipoPlanta>
    {
        public TipoPlanta BuscarTipoPlantaPorNombre(string nombre);

        public List<TipoPlanta> ListaDeTipoPlantasPorNombre(string nombre);

    }
}
