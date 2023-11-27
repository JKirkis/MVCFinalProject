using Microsoft.AspNetCore.Mvc;
using MVCFinalProject.Models;
using System.Diagnostics;

namespace MVCFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private GameContext context {  get; set; }  

        public HomeController(GameContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var games = context.Games;
            return View(games);
        }
    }
}