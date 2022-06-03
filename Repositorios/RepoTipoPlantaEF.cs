using System;
using System.Collections.Generic;
using System.Text;
using ObligatorioP3.EntidadesNegocio;
using ObligatorioP3.InterfacesRepositorio;
using System.Linq;

namespace Repositorios
{
    public class RepoTipoPlantaEF : IRepositorioTipoPlanta
    {
        public LibreriaContext Contexto { get; set; }

        public RepoTipoPlantaEF(LibreriaContext ctx)
        {
            Contexto = ctx;
        }

        public bool Add(TipoPlanta obj)
        {
            bool ok = false;

            Contexto.TiposPlantas.Add(obj);
            int afectadas = Contexto.SaveChanges();
            ok = afectadas >= 1;

            return ok;
        }

        public TipoPlanta BuscarTipoPlantaPorNombre(string nombre)
        {
            return Contexto.TiposPlantas.Where(tp => tp.Nombre == nombre).SingleOrDefault();
        }

        public IEnumerable<TipoPlanta> FindAll()
        {
            return Contexto.TiposPlantas.ToList();
        }

        public TipoPlanta FindById(int id)
        {
            return Contexto.TiposPlantas.Find(id);
        }

        public List<TipoPlanta> ListaDeTipoPlantasPorNombre(string nombre)
        {
            var query = Contexto.TiposPlantas
                        .Where(tp => tp.Nombre.Contains(nombre))
                        .Select(tp => tp);

            foreach (TipoPlanta item in query)
            {
                item.Nombre = nombre;
            }

            return Contexto.TiposPlantas.ToList();
        }

        public bool Remove(int id)
        {
            bool ok = false;

            TipoPlanta tp = new TipoPlanta() { Id = id };
            Contexto.TiposPlantas.Remove(tp);
            
            ok = Contexto.SaveChanges() >= 1;
                       

            return ok;
        }

        public bool Update(TipoPlanta obj)
        {
            var query = Contexto.TiposPlantas
                        .Where(tp => tp.Id == obj.Id);
                        

            foreach (TipoPlanta item in query)
            {
                item.Descripcion = obj.Descripcion;
            }

            Contexto.TiposPlantas.Update(obj);
            return Contexto.SaveChanges() >= 1;
        }
    }
}
