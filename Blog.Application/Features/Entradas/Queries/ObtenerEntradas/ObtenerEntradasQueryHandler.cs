using AutoMapper;
using Blog.Application.Contracts;
using MediatR;

namespace Blog.Application.Features.Entradas.Queries.FiltrarEntradas
{
    public class ObtenerEntradasQueryHandler : IRequestHandler<ObtenerEntradasQuery, List<EntradasVM>>
    {
        private readonly IMapper _mapper;
        private readonly IEntradaRepository _entradaRepository;

        public ObtenerEntradasQueryHandler(IMapper mapper, IEntradaRepository entradaRepository)
        {
            _mapper = mapper;
            _entradaRepository = entradaRepository;
        }

        async Task<List<EntradasVM>> IRequestHandler<ObtenerEntradasQuery, List<EntradasVM>>.Handle(ObtenerEntradasQuery request, CancellationToken cancellationToken)
        {
            var entradas = await _entradaRepository.ObtenerAsync(request._Filtro);
            return _mapper.Map<List<EntradasVM>>(entradas);
        }
    }
}
