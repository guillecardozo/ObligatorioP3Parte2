using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public class ManejadorPlanta : IManejadorPlanta
    {
        public IRepositorioPlanta RepoPlanta { get; set; }

        public IRepositorioFichaCuidados RepoFicha { get; set; }

        public IRepositorioTipoPlanta RepoTipo { get; set; }

        public ManejadorPlanta(IRepositorioPlanta repoPlanta, IRepositorioFichaCuidados repoFicha, IRepositorioTipoPlanta repoTipo)
        {
            RepoPlanta = repoPlanta;
            RepoTipo = repoTipo;
            RepoFicha = repoFicha;
        }


        public IEnumerable<TipoPlanta> TodosLosTipos()
        {
            return RepoTipo.FindAll();
        }

        public IEnumerable<FichaCuidados> TodasLasFichas()
        {
            return RepoFicha.FindAll();
        }

        #region Create

        public bool CrearNuevaPlanta(Planta p, int idTipo, int idFicha)
        {
            bool ok = false;

            TipoPlanta tipo = RepoTipo.FindById(idTipo);
            FichaCuidados ficha = RepoFicha.FindById(idFicha);

            if (tipo != null && ficha != null)
            {
                p.TipoPlanta = tipo;
                p.FichaCuidados = ficha;
                ok = RepoPlanta.Add(p);
            }
            return ok;
        }
        #endregion

        #region FindAll
        public IEnumerable<Planta> TodasLasPlantas()
        {
            return RepoPlanta.FindAll();
        }
        #endregion

        #region Traer Una Planta
        public Planta TraerUnaPlanta(int id)
        {
            return RepoPlanta.FindById(id);
        }
        #endregion

        #region Remove
        public bool EliminarUnaPlanta(int id)
        {
            return RepoPlanta.Remove(id);
        }
        #endregion

        #region Busqueda de Planta por Nombre
        public Planta BuscarPlantaPorNombre(string nombre)
        {
            return RepoPlanta.BuscarPlantaPorNombreVulgar(nombre);
        }
        #endregion

        #region Listado Por Nombre
        public List<Planta> ListadoSegunNombre(string nombre)
        {
            return RepoPlanta.ListaDePlantasPorNombre(nombre);
        }
        #endregion

        #region Listado Por Tipos
        public List<Planta> ListaPlantasSegunTipo(int id)
        {
            return RepoPlanta.ListaDePlantasSegunTipos(id);
        }
        #endregion

        #region Listado Por Ambiente
        public List<Planta> ListadoSegunAmbiente(string ambiente)
        {
            return RepoPlanta.ListaSegunAmbiente(ambiente);
        }
        #endregion

        #region Listado Por Altura mas baja
        public List<Planta> ListadoSegunAlturaMasBaja(int altura)
        {
            return RepoPlanta.ListaSegunAlturaBaja(altura);
        }
        #endregion

        #region Listado Por Altura mas alta
        public List<Planta> ListadoSegunAlturaMasAlta(int altura)
        {
            return RepoPlanta.ListaSegunAlturaAlta(altura);
        }
        #endregion
    }
}
