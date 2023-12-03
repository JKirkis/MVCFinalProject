using Microsoft.AspNetCore.Mvc;
using MVCFinalProject.Models;


namespace MVCFinalProject.Controllers
{
    public class GameController : Controller
    {

        private GameContext context { get; set; }

        public GameController(GameContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult FilteredGames(string genreFilter)
        {
            var games = context.Games.AsQueryable();

            ViewData["SelectedGenre"] = genreFilter;

            if (!string.IsNullOrEmpty(genreFilter))
            {
                games = games.Where(g => g.Genre == genreFilter);
            }

            return View("FilteredIndex", games.ToList());
        }




        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Game());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.GameId == 0)
                    context.Games.Add(game);
                else
                    context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (game.GameId == 0) ? "Add" : "Edit";
                return View(game);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Route("games/details-by-name/{name}")]
        public IActionResult DetailsByName(string name)
        {
            var game = context.Games.FirstOrDefault(g => g.Name == name);

            if (game == null)
            {
                return NotFound(); 
            }

            return View("Details", game);
        }

    }
}