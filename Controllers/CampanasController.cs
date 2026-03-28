// Versión de Resumen - CONFLICTO CON LOS FILTROS
using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using PortalCampanas.Data;


namespace PortalCampanas.Controllers;
public class CampanasController : Controller {
    public IActionResult Index() {
        // ESTO VA A CHOCAR CON LOS FILTROS
        var lista = DataStorage.Campanas.Take(3).ToList();
        return View(lista);
    }

    public IActionResult Detalle(int id)
    {
        var campana = DataStorage.Campanas.FirstOrDefault(c => c.Id == id);
        if (campana == null) return NotFound();
        return View(campana);
    }

    public IActionResult Resumen()
    {
        var campanas = DataStorage.Campanas;
        ViewBag.Total = campanas.Count;
        ViewBag.Vigentes = campanas.Count(c => c.Estado == "Vigente");
        return View();
    }
}