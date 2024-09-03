using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06_Cordero_Lipreti.Models;

namespace TP06_Cordero_Lipreti.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deportes()
        {
            ViewBag.Deportes = BD.ListarDeportes();
            return View();
        }

        public IActionResult Paises()
        {
            ViewBag.Paises = BD.ListarPaises();
            return View();
        }

        public IActionResult VerDetalleDeporte(int idDeporte)
        {
            ViewBag.Deporte = BD.VerInfoDeporte(idDeporte);
            ViewBag.Deportistas = BD.ListarDeportistasPorDeporte(idDeporte);
            return View();
        }

        public IActionResult VerDetallePais(int idPais)
        {
            ViewBag.Pais = BD.VerInfoPais(idPais);
            ViewBag.Deportistas = BD.ListarDeportistasPorPais(idPais);
            return View();
        }

        public IActionResult VerDetalleDeportista(int idDeportista)
        {
            ViewBag.Deportista = BD.VerInfoDeportista(idDeportista);
            return View();
        }

        public IActionResult AgregarDeportista()
        {
            ViewBag.Paises = BD.ListarPaises();
            ViewBag.Deportes = BD.ListarDeportes();
            return View();
        }

        [HttpPost]
        public IActionResult GuardarDeportista(Deportista dep)
        {
            if (ModelState.IsValid)
            {
                BD.AgregarDeportista(dep);
                return RedirectToAction("Index");
            }

            // If model state is invalid, return to the view with the current data
            ViewBag.Paises = BD.ListarPaises();
            ViewBag.Deportes = BD.ListarDeportes();
            return View("AgregarDeportista", dep);
        }

        public IActionResult EliminarDeportista(int idDeportista)
        {
            BD.EliminarDeportista(idDeportista);
            return RedirectToAction("Index");
        }

        public IActionResult Creditos()
        {
            return View();
        }
    }
}