using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
