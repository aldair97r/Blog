using Blog.Application.Features.Entradas.Commands.AgregarEntrada;
using Blog.Application.Features.Entradas.Queries.FiltrarEntradas;
using Blog.Application.Features.Entradas.Queries.ObtenerEntradaPorId;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EntradasController(IMediator mediator)
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

        [HttpGet("ObtenerEntradaPorId/{id}", Name = "ObtenerEntradaPorId")]
        [ProducesResponseType(typeof(IEnumerable<EntradasVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<EntradasVM>>> ObtenerEntradas(int id)
        {
            var query = new ObtenerEntradaPorIdQuery(id);
            var entrada = await _mediator.Send(query);
            return Ok(entrada);
        }

        [HttpPost(Name = "AgregarEntrada")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateStramer([FromBody] AgregarEntradaCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
