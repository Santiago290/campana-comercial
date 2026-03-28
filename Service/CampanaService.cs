using campana_comercial.Models;

namespace campana_comercial.Services
{
    public static class CampanaService
    {
        public static List<Campana> ObtenerCampanas()
        {
            return new List<Campana>
            {
                new Campana {
                    Id = 1,
                    Nombre = "CyberWow Electro",
                    Categoria = "Electro",
                    Estado = "Vigente",
                    Canal = "Web",
                    DescuentoPct = 30,
                    FechaInicio = DateTime.Now.AddDays(-5),
                    FechaFin = DateTime.Now.AddDays(5),
                    Descripcion = "Ofertas en productos electrónicos"
                },
                new Campana {
                    Id = 2,
                    Nombre = "Renueva tu Hogar",
                    Categoria = "Hogar",
                    Estado = "Vigente",
                    Canal = "Tienda",
                    DescuentoPct = 25,
                    FechaInicio = DateTime.Now.AddDays(-3),
                    FechaFin = DateTime.Now.AddDays(7),
                    Descripcion = "Descuentos en muebles y decoración"
                },
                new Campana {
                    Id = 3,
                    Nombre = "Fashion Week",
                    Categoria = "Moda",
                    Estado = "Próxima",
                    Canal = "App",
                    DescuentoPct = 40,
                    FechaInicio = DateTime.Now.AddDays(10),
                    FechaFin = DateTime.Now.AddDays(20),
                    Descripcion = "Campaña de ropa y accesorios"
                },
                new Campana {
                    Id = 4,
                    Nombre = "Tech Days",
                    Categoria = "Tecnología",
                    Estado = "Próxima",
                    Canal = "Web",
                    DescuentoPct = 35,
                    FechaInicio = DateTime.Now.AddDays(8),
                    FechaFin = DateTime.Now.AddDays(15),
                    Descripcion = "Ofertas en tecnología"
                },
                new Campana {
                    Id = 5,
                    Nombre = "Liquidación Verano",
                    Categoria = "Moda",
                    Estado = "Finalizada",
                    Canal = "Tienda",
                    DescuentoPct = 50,
                    FechaInicio = DateTime.Now.AddDays(-20),
                    FechaFin = DateTime.Now.AddDays(-10),
                    Descripcion = "Liquidación de temporada"
                }
            };
        }
    }
}