namespace Blog.Domain
{
    public class Entrada
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get; set; }
        public string Contenido { get; set; } = string.Empty;
    }
}
