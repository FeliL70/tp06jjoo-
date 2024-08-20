using Microsoft.AspNetCore.Mvc;

public class JJOOController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Paises()
    {
        ViewBag.Paises = BD.ListarPaises();
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

    [HttpPost]
    public IActionResult GuardarDeportista(Deportista dep)
    {
        BD.AgregarDeportista(dep);
        return RedirectToAction("Index");
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
