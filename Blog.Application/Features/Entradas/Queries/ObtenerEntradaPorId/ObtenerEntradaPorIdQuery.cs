using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Features.Entradas.Queries.ObtenerEntradaPorId
{
    public class ObtenerEntradaPorIdQuery : IRequest<EntradaVM>
    {
        public int _Id { get; set; }

        public ObtenerEntradaPorIdQuery(int id)
        {
            _Id = id;
        }
    }
}
