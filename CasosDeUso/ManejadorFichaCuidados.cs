using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public class ManejadorFichaCuidados : IManejadorFichaCuidados
    {
        public IRepositorioFichaCuidados RepoFicha { get; set; }

        public ManejadorFichaCuidados(IRepositorioFichaCuidados repoFicha)
        {
            RepoFicha = repoFicha;
        }

        #region Agregar ficha
        public bool AgregarFicha(FichaCuidados unaF)
        {
            return RepoFicha.Add(unaF);
        }
        #endregion

        #region FindAll
        public IEnumerable<FichaCuidados> TodasLasFichas()
        {
            return RepoFicha.FindAll();
        }
        #endregion

        #region FindById
        public FichaCuidados TraerUnaFicha(int id)
        {
            return RepoFicha.FindById(id);
        }
        #endregion

        #region Eliminar 
        public bool EliminarFicha(int id)
        {
            return RepoFicha.Remove(id);
        }

        #endregion 
    }
}
