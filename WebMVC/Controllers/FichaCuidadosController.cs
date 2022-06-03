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
    public class FichaCuidadosController : Controller
    {
        public IManejadorFichaCuidados Ficha { get; set; }

        public FichaCuidadosController(IManejadorFichaCuidados ficha)
        {
            Ficha = ficha;
        }

        #region Index
        // GET: FichaCuidadosController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<FichaCuidados> Fichas = Ficha.TodasLasFichas();
                return View(Fichas);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }
        #endregion

        #region Crear
        // GET: FichaCuidadosController/Create
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

        // POST: FichaCuidadosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FichaCuidados ficha, string iluminacion)
        {
            ficha.TipoIluminacion = iluminacion;

            try
            {
                bool ok = Ficha.AgregarFicha(ficha);
                
                if (ok)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ok = "No se registro correctamente";
                    return View();
                }
            }

            catch (Exception)
            {
                ViewBag.MensajeError = "Error";
                return View();
            }
        }
        #endregion

        #region Eliminar
        // GET: FichaCuidadosController/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                FichaCuidados unF = Ficha.TraerUnaFicha(id);
                return View(unF);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        // POST: FichaCuidadosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Ficha.TraerUnaFicha(id);
            
            try
            {
                bool ok = Ficha.EliminarFicha(id);
                
                if (ok)
                {
                    ViewBag.Ok = "Eliminado correctamente";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "No se pudo eliminar";
                    return View();
                }
            }
            
            catch
            {
                ViewBag.Error = "Error";
                return View();
            }
        }
        #endregion

        #region Detalles
        // GET: FichaCuidadosController/Details/5
        public ActionResult Details(int id)
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
        #endregion

        #region Editar
        // GET: FichaCuidadosController/Edit/5
        public ActionResult Edit(int id)
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

        // POST: FichaCuidadosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
