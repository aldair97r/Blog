using AutoMapper;
using Blog.Application.Contracts;
using Blog.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Blog.Application.Features.Entradas.Commands.AgregarEntrada
{
    public class AgregarEntradaCommandHandler : IRequestHandler<AgregarEntradaCommand, int>
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AgregarEntradaCommandHandler> _logger;
        public AgregarEntradaCommandHandler(IEntradaRepository entradaRepository, IMapper mapper, ILogger<AgregarEntradaCommandHandler> logger)
        {
            _entradaRepository = entradaRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(AgregarEntradaCommand request, CancellationToken cancellationToken)
        {
            var entradaEntity = _mapper.Map<Entrada>(request);
            var entradaNueva = await _entradaRepository.AgregarAsync(entradaEntity);
            _logger.LogInformation($"Entrada: {entradaNueva.Id} fue creada correctamente.");
            return entradaEntity.Id;
        }
    }
}
