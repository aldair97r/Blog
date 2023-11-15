using MediatR;

namespace Blog.Application.Features.Entradas.Queries.FiltrarEntradas
{
    public class ObtenerEntradasQuery : IRequest<List<EntradasVM>>
    {
        public string? _Filtro { get; set; } = string.Empty;

        public ObtenerEntradasQuery(string filtro)
        {
            _Filtro = filtro;
        }
    }
}
