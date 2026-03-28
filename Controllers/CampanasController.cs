using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using PortalCampanas.Data;

namespace PortalCampanas.Controllers;

public class CampanasController : Controller
{
    // Acción para el Listado
    public IActionResult Index()
    {
        var lista = DataStorage.Campanas;
        return View(lista);
    }

    // Acción para el Detalle
    public IActionResult Detalle(int id)
    {
        var campana = DataStorage.Campanas.FirstOrDefault(c => c.Id == id);
        if (campana == null) return NotFound();
        return View(campana);
    }
}