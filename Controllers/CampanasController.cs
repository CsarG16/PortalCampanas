using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using PortalCampanas.Data;

namespace PortalCampanas.Controllers;
public class CampanasController : Controller {
    public IActionResult Index() {
        var lista = DataStorage.Campanas;
        return View(lista);
    }
}