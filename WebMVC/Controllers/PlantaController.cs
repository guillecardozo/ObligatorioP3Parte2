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
    public class PlantaController : Controller
    {
        public IManejadorPlanta Planta { get; set; }

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        public PlantaController(IManejadorPlanta planta, IWebHostEnvironment whenv)
        {
            Planta = planta;
            WebHostEnvironment = whenv;
        }


        #region Index
        // GET: PlantaController1
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<Planta> TodasLasPlantas = Planta.TodasLasPlantas();
                return View(TodasLasPlantas);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }
        #endregion

        #region Detalles 
        // GET: PlantaController1/Details/5
        public ActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                Planta UnaPlanta = Planta.TraerUnaPlanta(id);
                ViewBag.Foto = UnaPlanta.Foto;
                return View(UnaPlanta);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }
        #endregion

        #region Crear 
        // GET: PlantaController1/Create
        public ActionResult Create()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                ViewModelPlanta vm = new ViewModelPlanta();
                vm.TipoPlanta = Planta.TodosLosTipos();
                vm.FichaCuidados = Planta.TodasLasFichas();
                return View(vm);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        // POST: PlantaController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViewModelPlanta vm, string ambiente)
        {
            vm.TipoPlanta = Planta.TodosLosTipos();
            vm.FichaCuidados = Planta.TodasLasFichas();
            vm.Planta.TipoAmbiente = ambiente;

            try
            {

                string nomArchivo = vm.Imagen.FileName;
                int largoString = nomArchivo.Length;
                string extension = nomArchivo.Substring((largoString - 4), 4);
                nomArchivo = vm.Planta.NombreCientifico + "_001" + extension;
                vm.Planta.Foto = nomArchivo;
                
                bool ok = Planta.CrearNuevaPlanta(vm.Planta, vm.IdTipoPlantaSeleccionada, vm.IdFichaCuidadoSeleccionada);

                if (ok)
                {
                    string rutaRaiz = WebHostEnvironment.WebRootPath;
                    string rutaImagenes = Path.Combine(rutaRaiz, "Img");
                    string rutaArchivo = Path.Combine(rutaImagenes, nomArchivo);

                    FileStream stream = new FileStream(rutaArchivo, FileMode.Create);
                    vm.Imagen.CopyTo(stream);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "No se pudo agregar la planta";
                    vm.TipoPlanta = Planta.TodosLosTipos();
                    vm.FichaCuidados = Planta.TodasLasFichas();
                    return View(vm);
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Error al ingresar la planta";
                return View(vm);
            }
        }
        #endregion

        #region Editar
        // GET: PlantaController1/Edit/5
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

        // POST: PlantaController1/Edit/5
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
        // GET: PlantaController1/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                Planta UnaPlanta = Planta.TraerUnaPlanta(id);
                ViewBag.Foto = UnaPlanta.Foto;
                return View(UnaPlanta);
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        // POST: PlantaController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                bool ok = Planta.EliminarUnaPlanta(id);
                
                if (ok)
                {
                    ViewBag.ok = "Se elimino correctamente";
                    return RedirectToAction(nameof(Index));
                }

                ViewBag.MensajeError = "Error al eliminar";
                Planta UnaPlanta = Planta.TraerUnaPlanta(id);
                return View(UnaPlanta);
            }
            
            catch
            {
                ViewBag.MensajeError = "Error";
                Planta UnaPlanta = Planta.TraerUnaPlanta(id);
                return View(UnaPlanta);
            }
        }
        #endregion

        #region Busqueda por Nombre
        public IActionResult BusquedaPorNombre()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<Planta> plantas = Planta.TodasLasPlantas();
                ViewBag.Planta = plantas;
                return View();
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        [HttpPost]
        public IActionResult BusquedaPorNombre(string nombre)
        {
            IEnumerable<Planta> plantas = Planta.TodasLasPlantas();
            ViewBag.Planta = plantas;

            List<Planta> Listado = Planta.ListadoSegunNombre(nombre);
            ViewBag.Listado = Listado;
            
            try
            {
                if (Listado.Count() >= 1)
                {
                    return View("ResultadoBusquedaNombre");
                }
                else
                {
                    ViewBag.MensajeError = "No se econtraron resultados";
                    return View("BusquedaPorNombre");
                }
            }
            
            catch (Exception)
            {
                return Redirect("Index");
                throw;
            }
        }
        #endregion

        #region Busqueda Segun Tipo de Planta
        public IActionResult BusquedaSegunTipoDePlanta()
        {
            if (HttpContext.Session.GetString("Rol") != null)
            {
                IEnumerable<TipoPlanta> TiposDePlantas = Planta.TodosLosTipos();
                ViewBag.TiposDePlanta = TiposDePlantas;
                return View();
            }
            else
            {
                return Redirect("/Usuario/LogIn");
            }
        }

        [HttpPost]
        public IActionResult BusquedaSegunTipoDePlanta(int id)
        {
            IEnumerable<TipoPlanta> TiposDePlantas = Planta.TodosLosTipos();
            ViewBag.TiposDePlanta = TiposDePlantas;

            List<Planta> Listado = Planta.ListaPlantasSegunTipo(id);
            ViewBag.Listado = Listado;
            
            try
            {
                if (Listado.Count() > 0)
                {
                    return View("ResultadoBusquedaNombre");
                }
                else
                {
                    ViewBag.MensajeError = "No se econtraron resultados";
                    return View();
                }
            }
            
            catch (Exception)
            {
                return Redirect("Index");
                throw;
            }
        }
        #endregion

        #region Busqueda Segun Ambiente
        public IActionResult BusquedaSegunAmbiente()
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

        [HttpPost]
        public IActionResult BusquedaSegunAmbiente(string ambiente)
        {
            List<Planta> Listado = Planta.ListadoSegunAmbiente(ambiente);
            ViewBag.Listado = Listado;
            
            try
            {
                if (Listado.Count() > 0)
                {
                    return View("ResultadoBusquedaNombre");//aca
                }
                else
                {
                    ViewBag.MensajeError = "No se econtraron resultados";
                    return View();//aca
                }
            }
            
            catch (Exception)
            {
                return Redirect("Index");
                throw;
            }
        }
        #endregion

        #region Busqueda segun Altura mas baja
        public IActionResult BusquedaSegunAlturaBaja()
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

        [HttpPost]
        public IActionResult BusquedaSegunAlturaBaja(int altura)
        {
            List<Planta> Listado = Planta.ListadoSegunAlturaMasBaja(altura);
            ViewBag.Listado = Listado;
            
            try
            {
                if (Listado.Count() > 0)
                {
                    return View("ResultadoBusquedaNombre");//aca
                }
                else
                {
                    ViewBag.MensajeError = "No se econtraron resultados";
                    return View();//aca
                }
            }
            
            catch (Exception)
            {
                return Redirect("Index");
                throw;
            }
        }
        #endregion

        #region Busqueda segun Altura mas alta
        public IActionResult BusquedaSegunAlturaAlta()
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

        [HttpPost]
        public IActionResult BusquedaSegunAlturaAlta(int altura)
        {
            List<Planta> Listado = Planta.ListadoSegunAlturaMasAlta(altura);
            ViewBag.Listado = Listado;
            
            try
            {
                if (Listado.Count() > 0)
                {
                    return View("ResultadoBusquedaNombre");//aca
                }
                else
                {
                    ViewBag.MensajeError = "No se econtraron resultados";
                    return View();//aca
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
