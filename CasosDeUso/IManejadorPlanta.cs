using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;

namespace CasosDeUso
{
    public interface IManejadorPlanta
    {
        IEnumerable<Planta> TodasLasPlantas();

        public Planta TraerUnaPlanta(int id);

        bool EliminarUnaPlanta(int id);

        IEnumerable<TipoPlanta> TodosLosTipos();

        IEnumerable<FichaCuidados> TodasLasFichas();

        public bool CrearNuevaPlanta(Planta p, int idTipo, int idFicha);

        public Planta BuscarPlantaPorNombre(string nombre);

        public List<Planta> ListadoSegunNombre(string nombre);

        public List<Planta> ListaPlantasSegunTipo(int id);

        public List<Planta> ListadoSegunAmbiente(string ambiente);

        public List<Planta> ListadoSegunAlturaMasBaja(int altura);

        public List<Planta> ListadoSegunAlturaMasAlta(int altura);
    }
}
