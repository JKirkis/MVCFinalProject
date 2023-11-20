using Microsoft.AspNetCore.Mvc;

namespace MVCFinalProject.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
