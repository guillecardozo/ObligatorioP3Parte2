using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;
using System.Linq;

namespace Repositorios
{
    public class RepoPlantaEF : IRepositorioPlanta
    {
        public LibreriaContext Contexto { get; set; }

        public RepoPlantaEF(LibreriaContext ctx)
        {
            Contexto = ctx;
        }

        public bool Add(Planta obj)
        {
            bool ok = false;

            Contexto.Plantas.Add(obj);
            int afectadas = Contexto.SaveChanges();
            ok = afectadas >= 1;

            return ok;
        }

        public Planta BuscarPlantaPorNombreVulgar(string nombre)
        {
            return Contexto.Plantas.Where(p => p.NombreVulgar == nombre).SingleOrDefault();
        }

        public IEnumerable<Planta> FindAll()
        {
            return Contexto.Plantas.ToList();
        }

        public Planta FindById(int id)
        {
            return Contexto.Plantas.Find(id);
        }

        public List<Planta> ListaDePlantasPorNombre(string nombre)
        {
            var query = Contexto.Plantas
                        .Where(p => p.NombreCientifico.Contains(nombre) || p.NombreVulgar.Contains(nombre))
                        .Select(p => p);

            foreach (Planta item in query)
            {
                item.NombreVulgar = nombre;
                item.NombreCientifico = nombre;
            }

            return Contexto.Plantas.ToList();
        }

        public List<Planta> ListaDePlantasSegunTipos(int id)
        {
            var query = Contexto.Plantas
                        .Where(p => p.TipoPlanta.Id == id);

            foreach (Planta item in query)
            {
                item.Id = id;
            }

            return Contexto.Plantas.ToList();
        }

        public List<Planta> ListaSegunAlturaAlta(int altura)
        {
            throw new NotImplementedException();
        }

        public List<Planta> ListaSegunAlturaBaja(int altura)
        {
            throw new NotImplementedException();
        }

        public List<Planta> ListaSegunAmbiente(string ambiente)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Planta obj)
        {
            throw new NotImplementedException();
        }
    }
}
