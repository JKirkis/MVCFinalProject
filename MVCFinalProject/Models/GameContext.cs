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
                }
             );
        }
    }
}
