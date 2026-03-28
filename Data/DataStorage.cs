using PortalCampanas.Models;

namespace PortalCampanas.Data;

public static class DataStorage {
    // Asegúrate de que diga 'public static'
    public static List<Campana> Campanas = new List<Campana>
    {
        new Campana { Id = 1, Nombre = "Cierra Puertas Electro", Categoria = "Electro", Estado = "Vigente", DescuentoPct = 40, Descripcion = "Grandes descuentos en refrigeración y lavado.", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(7), Canal = "Web" },
        new Campana { Id = 2, Nombre = "Semana Gamer", Categoria = "Tecnología", Estado = "Proxima", DescuentoPct = 25, Descripcion = "Todo en periféricos y laptops gaming.", FechaInicio = DateTime.Now.AddDays(5), FechaFin = DateTime.Now.AddDays(15), Canal = "Físico" },
        new Campana { Id = 3, Nombre = "Renueva tu Hogar", Categoria = "Hogar", Estado = "Vigente", DescuentoPct = 30, Descripcion = "Muebles y decoración.", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(10), Canal = "Web" },
        new Campana { Id = 4, Nombre = "Moda Invierno 2026", Categoria = "Moda", Estado = "Finalizada", DescuentoPct = 50, Descripcion = "Liquidación.", FechaInicio = DateTime.Now.AddDays(-30), FechaFin = DateTime.Now.AddDays(-1), Canal = "Físico" },
        new Campana { Id = 5, Nombre = "Smartphone Fest", Categoria = "Tecnología", Estado = "Vigente", DescuentoPct = 15, Descripcion = "Lanzamientos exclusivos.", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(5), Canal = "App" },
        new Campana { Id = 6, Nombre = "Vuelta a Clases", Categoria = "Escolar", Estado = "Proxima", DescuentoPct = 20, Descripcion = "Útiles y mochilas.", FechaInicio = DateTime.Now.AddDays(20), FechaFin = DateTime.Now.AddDays(40), Canal = "Web" }
    };
}