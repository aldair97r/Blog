using MediatR;

namespace Blog.Application.Features.Entradas.Commands.AgregarEntrada
{
    public class AgregarEntradaCommand : IRequest<int>
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get; set; }
        public string Contenido { get; set; } = string.Empty;
    }
}
