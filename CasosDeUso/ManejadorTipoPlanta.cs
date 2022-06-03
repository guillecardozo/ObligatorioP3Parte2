using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;


namespace CasosDeUso
{
    public class ManejadorTipoPlanta : IManejadorTipoPlanta
    {
        public IRepositorioTipoPlanta RepoTipoPlanta { get; set; }

        public ManejadorTipoPlanta(IRepositorioTipoPlanta repoTipoPlanta)
        {
            RepoTipoPlanta = repoTipoPlanta;
        }

        #region Agregar Tipo
        public bool AgregarTipoPlanta(TipoPlanta tipo)
        {
            return RepoTipoPlanta.Add(tipo);
        }
        #endregion

        #region FindAll
        public IEnumerable<TipoPlanta> TodosLosTiposDePlantas()
        {
            return RepoTipoPlanta.FindAll();
        }
        #endregion

        #region Remove
        public bool EliminarTipoPlanta(int id)
        {
            return RepoTipoPlanta.Remove(id);
        }
        #endregion

        #region FindById
        public TipoPlanta TraerUnTipo(int id)
        {
            return RepoTipoPlanta.FindById(id);
        }
        #endregion

        #region Update
        public bool EditarDescripcion(TipoPlanta obj)
        {
            return RepoTipoPlanta.Update(obj);
        }
        #endregion

        #region Busqueda de Tipo de Planta por Nombre
        public TipoPlanta BuscarTipoDePlantaPorNombre(string nombre)
        {
            return RepoTipoPlanta.BuscarTipoPlantaPorNombre(nombre);
        }
        #endregion

        #region Listado Por Tipo Nombre
        public List<TipoPlanta> ListadoSegunNombreTipo(string nombre)
        {
            return RepoTipoPlanta.ListaDeTipoPlantasPorNombre(nombre);
        }
        #endregion
    }
}
