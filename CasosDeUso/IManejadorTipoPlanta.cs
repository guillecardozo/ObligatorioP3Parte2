using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public interface IManejadorTipoPlanta
    {
        IEnumerable<TipoPlanta> TodosLosTiposDePlantas();

        public bool AgregarTipoPlanta(TipoPlanta tipo);
        
        public TipoPlanta TraerUnTipo(int id);

        public bool EliminarTipoPlanta(int id);

        public bool EditarDescripcion(TipoPlanta obj);

        public TipoPlanta BuscarTipoDePlantaPorNombre(string nombre);

        public List<TipoPlanta> ListadoSegunNombreTipo(string nombre);
    }
}
