using AutoMapper;
using Blog.Application.Contracts;
using Blog.Application.Features.Entradas.Queries.FiltrarEntradas;
using MediatR;

namespace Blog.Application.Features.Entradas.Queries.ObtenerEntradaPorId
{
    public class ObtenerEntradaPorIdQueryHandler : IRequestHandler<ObtenerEntradaPorIdQuery, EntradaVM>
    {
        private readonly IMapper _mapper;
        private readonly IEntradaRepository _entradaRepository;
        public ObtenerEntradaPorIdQueryHandler(IMapper mapper, IEntradaRepository entradaRepository)
        {
            _mapper = mapper;
            _entradaRepository = entradaRepository;
        }

        public async Task<EntradaVM> Handle(ObtenerEntradaPorIdQuery request, CancellationToken cancellationToken)
        {
            var entrada = await _entradaRepository.ObtenerPorIdAsync(request._Id);
            return _mapper.Map<EntradaVM>(entrada);
        }
    }
}
