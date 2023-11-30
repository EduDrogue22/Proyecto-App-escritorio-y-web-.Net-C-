using Conexion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Producto()
        {
            SERVICIO_LIMPIEZAEntities db = new SERVICIO_LIMPIEZAEntities();
            var registro_aleatorio = db.Producto.OrderBy(x => Guid.NewGuid()).ToList();
            ViewBag.Productos = registro_aleatorio;
            return View();
        }

        public ActionResult Calificacion_servicio()
        {
            SERVICIO_LIMPIEZAEntities db = new SERVICIO_LIMPIEZAEntities();
            ViewBag.Calificacion_de_servicio = db.Calificacion_de_servicio.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Contacto()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Contacto(string nombre, string email, string mensaje)
        {
            ViewBag.nombre = nombre;
            ViewBag.email = email;
            ViewBag.mensaje = mensaje;
            return View();
        } 
    }
}