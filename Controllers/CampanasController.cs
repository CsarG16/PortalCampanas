using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using PortalCampanas.Data;

namespace PortalCampanas.Controllers;
public class CampanasController : Controller {
    public IActionResult Index(string categoria, string estado)
    {
        var lista = DataStorage.Campanas.AsEnumerable();

        if (!string.IsNullOrEmpty(categoria))
            lista = lista.Where(c => c.Categoria.Contains(categoria, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrEmpty(estado))
            lista = lista.Where(c => c.Estado.Contains(estado, StringComparison.OrdinalIgnoreCase));

        return View(lista.ToList());
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