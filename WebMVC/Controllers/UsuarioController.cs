using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioP3.EntidadesNegocio;
using CasosDeUso;


namespace WebMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // Inyecto un atributo de tipo IManejadorUsuario 
        public IManejadorUsuario ManejadorUsuario { get; set; }

        public UsuarioController(IManejadorUsuario manejador)
        {
            ManejadorUsuario = manejador;
        }

        #region Index
        // GET: UsuarioController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<Usuario> usuarios = ManejadorUsuario.TodosLosUsuarios();
                return View(usuarios);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }
        #endregion

        #region Detalles
        // GET: UsuarioController/Details/5
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

        #region Crear
        // GET: UsuarioController/Create
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

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        #region Editar
        // GET: UsuarioController/Edit/5
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

        // POST: UsuarioController/Edit/5
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

        #region Eliminar
        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
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

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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

        #region LogIn
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(string mail, string contra)
        {
            Usuario unUs = ManejadorUsuario.LogIn(mail, contra);
            ViewBag.Email = mail;
            ViewBag.Password = contra;
            try
            {
                if (unUs != null)
                {
                    HttpContext.Session.SetString("Rol", unUs.Rol);
                    return Redirect("/Home/Index");
                }
                else
                {
                    ViewBag.MensajeError = "Datos incorrectos";
                    return View();
                }
            }
            
            catch
            {
                return View();
            }
        }
        #endregion

        #region LogOut
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LogIn");
        }
        #endregion
    }
}
