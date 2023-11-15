using Blog.Application.Contracts;
using Blog.Domain;
using Blog.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        protected readonly BlogDbContext _context;

        public EntradaRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Entrada> AgregarAsync(Entrada entrada)
        {
            _context.Set<Entrada>().Add(entrada);
            await _context.SaveChangesAsync();
            return entrada;
        }

        public async Task<List<Entrada>> ObtenerAsync(string filtro = null)
        {
            var entradas = await _context.Set<Entrada>().ToListAsync();
            if (filtro != null)
                entradas = entradas.Where(x => x.Titulo.Contains(filtro) || x.Autor.Contains(filtro) || x.Contenido.Contains(filtro)).ToList();
            return entradas;
        }
    }
}
