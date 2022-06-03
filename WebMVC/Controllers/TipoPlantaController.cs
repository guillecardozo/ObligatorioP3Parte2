using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioP3.EntidadesNegocio;
using CasosDeUso;
using WebMVC.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace WebMVC.Controllers
{
    public class TipoPlantaController : Controller
    {
        public IManejadorTipoPlanta TipoPlanta { get; set; }

        public TipoPlantaController(IManejadorTipoPlanta tipo)
        {
            TipoPlanta = tipo;
        }

        #region Index
        // GET: TipoPlantaController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<TipoPlanta> tiposDePlantas = TipoPlanta.TodosLosTiposDePlantas();
                if (tiposDePlantas == null)
                {
                    ViewBag.MensajeError = "No se encontraron tipos de plantas";
                }

                return View(tiposDePlantas);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }
        #endregion

        #region Eliminar
        
        // GET: TipoPlantaController/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                TipoPlanta tipo = TipoPlanta.TraerUnTipo(id);
                return View(tipo);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        // POST: TipoPlantaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                bool ok = TipoPlanta.EliminarTipoPlanta(id);
                return RedirectToAction(nameof(Index));
            }
            
            catch
            {
                ViewBag.MensajeError = "Error al eliminar";
                TipoPlanta tipo = TipoPlanta.TraerUnTipo(id);
                return View(tipo);
            }
        }
        #endregion

        #region Editar

        // GET: TipoPlantaController/Edit/5
        public ActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                ViewBag.Id = id;
                TipoPlanta tipo = TipoPlanta.TraerUnTipo(id);
                ViewBag.Nombre = tipo.Nombre;
                ViewBag.Descripcion = tipo.Descripcion;
                return View(tipo);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        // POST: TipoPlantaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoPlanta tipo)
        {
            try
            {
                ViewBag.Id = tipo;
                ViewBag.Nombre = tipo.Nombre;
                ViewBag.Descripcion = tipo.Descripcion;
                bool ok = TipoPlanta.EditarDescripcion(tipo);
            
                if (ok)
                {
                    return RedirectToAction(nameof(Index));
                }
                
                else
                {
                    ViewBag.MensajeError = "No se pudo editar";
                    return View();
                }
            }
            
            catch
            {
                ViewBag.MensajeError = "Error";
                return View();
            }
        }
        #endregion

        #region Crear

        // GET: TipoPlantaController/Create
        public ActionResult Create()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                return View();
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        // POST: TipoPlantaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoPlanta tipo)
        {
            try
            {
                bool ok = TipoPlanta.AgregarTipoPlanta(tipo);
                if (ok)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.MensajeError = "Error al registrar";
                    return View();
                }
            }
            
            catch
            {
                ViewBag.MensajeError = "Error";
                return View();
            }
        }
        #endregion

        #region Busqueda por Nombre
        public IActionResult BusquedaPorTipoNombre()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<TipoPlanta> tipoPlantas = TipoPlanta.TodosLosTiposDePlantas();
                ViewBag.TipoPlanta = tipoPlantas;
                return View();
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        [HttpPost]
        public IActionResult BusquedaPorTipoNombre(string nombre)
        {
            IEnumerable<TipoPlanta> tipoPlantas = TipoPlanta.TodosLosTiposDePlantas();
            ViewBag.TipoPlanta = tipoPlantas;

            List<TipoPlanta> Listado = TipoPlanta.ListadoSegunNombreTipo(nombre);
            ViewBag.Listado = Listado;

            try
            {
                if (Listado.Count() >= 1)
                {
                    return View("ResultadoBusquedaTipoPlanta");
                }
                else
                {
                    ViewBag.MensajeError = "No se econtraron resultados";
                    return View("BusquedaPorTipoNombre");
                }
            }

            catch (Exception)
            {
                return Redirect("Index");
                throw;
            }
        }
        #endregion
    }
}
