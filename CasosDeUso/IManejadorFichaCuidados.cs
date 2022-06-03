using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public interface IManejadorFichaCuidados
    {
        IEnumerable<FichaCuidados> TodasLasFichas();
        
        public bool AgregarFicha(FichaCuidados unaF);

        public FichaCuidados TraerUnaFicha(int id);

        public bool EliminarFicha(int id);
    }
}
