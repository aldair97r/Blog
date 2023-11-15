using FluentValidation;

namespace Blog.Application.Features.Entradas.Commands.AgregarEntrada
{
    public class AgregarEntradaCommandValidator : AbstractValidator<AgregarEntradaCommand>
    {
        public AgregarEntradaCommandValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty().WithMessage("El titulo es requerido");

            RuleFor(x => x.Autor)
               .NotEmpty().WithMessage("El autor es requerido");

            RuleFor(x => x.FechaPublicacion)
               .NotEmpty().WithMessage("La fecha de publicacion es requerida");

            RuleFor(x => x.Contenido)
               .NotEmpty().WithMessage("El contenido es obligatorio");
        }
    }
}
