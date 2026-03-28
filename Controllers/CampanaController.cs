using Microsoft.AspNetCore.Mvc;
using campana_comercial.Services;
using campana_comercial.Models;

namespace campana_comercial.Controllers
{
    public class CampanasController : Controller
    {
        // LISTADO + FILTRO
        public IActionResult Index(string categoria, string estado)
        {
            var datos = CampanaService.ObtenerCampanas();

            if (!string.IsNullOrEmpty(categoria))
                datos = datos.Where(x => x.Categoria == categoria).ToList();

            if (!string.IsNullOrEmpty(estado))
                datos = datos.Where(x => x.Estado == estado).ToList();

            return View(datos);
        }

        // DETALLE
        public IActionResult Detalle(int id)
        {
            var campana = CampanaService.ObtenerCampanas()
                            .FirstOrDefault(x => x.Id == id);

            return View(campana);
        }

        // RESUMEN
        public IActionResult Resumen()
        {
            var datos = CampanaService.ObtenerCampanas();

            ViewBag.Total = datos.Count;
            ViewBag.Vigentes = datos.Count(x => x.Estado == "Vigente");
            ViewBag.Proximas = datos.Count(x => x.Estado == "Próxima");
            ViewBag.Finalizadas = datos.Count(x => x.Estado == "Finalizada");

            ViewBag.PromedioDescuento = datos.Average(x => x.DescuentoPct);

            ViewBag.Web = datos.Count(x => x.Canal == "Web");
            ViewBag.App = datos.Count(x => x.Canal == "App");
            ViewBag.Tienda = datos.Count(x => x.Canal == "Tienda");

            return View();
        }
    }
}