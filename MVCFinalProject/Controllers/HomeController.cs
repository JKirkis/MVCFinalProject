/*
    This is the HomeController where it redirects you to the index
 */

using Microsoft.AspNetCore.Mvc;
using MVCFinalProject.Models;
using System.Diagnostics;

namespace MVCFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private GameContext context { get; set; }

        public HomeController(GameContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var games = context.Games.OrderBy(x => x.Year).ToList();
            return View(games);
        }
    }
}