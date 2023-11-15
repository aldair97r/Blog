using Blog.Application.Features.Entradas.Commands.AgregarEntrada;
using Blog.Application.Features.Entradas.Queries.FiltrarEntradas;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EntradaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{filtro?}", Name = "ObtenerEntradas")]
        [ProducesResponseType(typeof(IEnumerable<EntradasVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<EntradasVM>>> ObtenerEntradas(string? filtro = null)
        {
            var query = new ObtenerEntradasQuery(filtro);
            var entradas = await _mediator.Send(query);
            return Ok(entradas);
        }

        [HttpPost(Name = "AgregarEntrada")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateStramer([FromBody] AgregarEntradaCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
