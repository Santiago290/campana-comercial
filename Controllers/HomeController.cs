using Microsoft.AspNetCore.Mvc;

namespace campana_comercial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Campanas");
        }
    }
}