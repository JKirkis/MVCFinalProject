using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;

namespace MVCFinalProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Confiugration = configuration;
        }
        public IConfiguration Confiugration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GameContext>(options =>
                options.UseSqlServer(
                    Confiugration.GetConnectionString("GameContext")));
        }
    }
}

