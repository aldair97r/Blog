namespace Blog.Application.Features.Entradas.Queries.ObtenerEntradaPorId
{
    public class EntradaVM
    {
        public int? Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string? Contenido { get; set; }
    }
}
