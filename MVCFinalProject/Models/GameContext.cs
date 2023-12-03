/*
 * This the gamecontext class it adds to the database
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace MVCFinalProject.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Name = "Doom",
                    Year = 1993,
                    Developer = "id Software",
                    Genre = "First-person shooter"
                },
                new Game
                {
                    GameId = 2,
                    Name = "Conker's Bad Fur Day",
                    Year = 2001,
                    Developer = "Rare",
                    Genre = "Adventure"
                },
                new Game
                {
                    GameId = 3,
                    Name = "World of Warcraft",
                    Year = 2004,
                    Developer = "Blizzard Entertainment",
                    Genre = "MMORPG"
                },
                new Game
                {
                    GameId = 4,
                    Name = "Halo",
                    Year = 2001,
                    Developer = "Bungie",
                    Genre = "First-person shooter"
                },
                new Game
                {
                    GameId = 5,
                    Name = "Final Fantasy 7",
                    Year = 1997,
                    Developer = "Square",
                    Genre = "Role-playing game"
                },
                new Game
                {
                    GameId = 6,
                    Name = "Extinction",
                    Year = 2023,
                    Developer = "NicKyLarry",
                    Genre = "First-person shooter"
                },
                new Game
                {
                    GameId = 7,
                    Name = "Mass Effect 3",
                    Year = 2012,
                    Developer = "Bioware",
                    Genre = "Role-playing game"
                },
                new Game
                {
                    GameId = 8,
                    Name = "Life is Strange",
                    Year = 2015,
                    Developer = "Don't Nod",
                    Genre = "Adventure"
                },
                new Game
                {
                    GameId = 9,
                    Name = "Day of the Tentacle",
                    Year = 1993,
                    Developer = "LucasArts",
                    Genre = "Adventure"
                }
             );
        }
    }
}
