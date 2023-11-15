using Blog.Domain;

namespace Blog.Application.Contracts
{
    public interface IEntradaRepository
    {
        Task<Entrada> AgregarAsync(Entrada entrada);
        Task<List<Entrada>> ObtenerAsync(string filtro);
    }
}
