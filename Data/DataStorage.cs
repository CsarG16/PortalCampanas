using PortalCampanas.Models;

namespace PortalCampanas.Data;

public static class DataStorage {
    public static List<Campana> Campanas = new List<Campana> {
        new Campana { Id = 1, Nombre = "Cierra Puertas Electro", Categoria = "Electro", Estado = "Vigente", FechaInicio = DateTime.Now.AddDays(-5), FechaFin = DateTime.Now.AddDays(2), DescuentoPct = 30, Canal = "Web", Descripcion = "Todo electro con dscto." },
        new Campana { Id = 2, Nombre = "Cyber App", Categoria = "Tecnología", Estado = "Proxima", FechaInicio = DateTime.Now.AddDays(5), FechaFin = DateTime.Now.AddDays(10), DescuentoPct = 40, Canal = "App", Descripcion = "Solo por el app." }
    };
}