using Blog.Domain;
using Microsoft.Extensions.Logging;

namespace Blog.Infrastructure.Persistence
{
    public class BlogDbContextSeed
    {
        public async Task SeedAsync(BlogDbContext context, ILogger<BlogDbContext> logger)
        {
            if (!context.Entradas!.Any())
            {
                context.Entradas!.AddRange(ObtenerEntradasPreconfiguradas());
                await context.SaveChangesAsync();
                logger.LogInformation("Insertando registros en la base de datos {context}", typeof(BlogDbContext).Name);
            }
        }

        private static IEnumerable<Entrada> ObtenerEntradasPreconfiguradas()
        {
            List<Entrada> entradas = new List<Entrada>();
            for (int i = 0; i < 2; i++)
            {
                Entrada entrada = new Entrada
                {
                    Autor = $"Autor {i}",
                    Titulo = $"Titulo {i}",
                    FechaPublicacion = DateTime.UtcNow,
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                };
                entradas.Add(entrada);
            }
            return entradas;
        }
    }
}
