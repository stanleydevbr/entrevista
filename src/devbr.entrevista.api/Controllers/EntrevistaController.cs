using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using Microsoft.AspNetCore.Mvc;

namespace DevBr.Entrevista.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EntrevistaController : ControllerBase
    {
        
        private readonly IEntrevistaAppService _service;

        public EntrevistaController(IEntrevistaAppService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] EntrevistaViewModel viewModel)
        {
            var result = _service.Adicionar(viewModel);

            return Ok(result);
        }

        [HttpGet]
        public IActionResult Consultar([FromQuery] Guid Id)
        {
            var result = _service.Consultar(Id);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Atualizar([FromBody] EntrevistaViewModel viewModel)
        {
            var result = _service.Editar(viewModel);

            return Ok(result);
        }

        [HttpDelete]

        public IActionResult Deletar([FromQuery] Guid Id)
        {
            var result = _service.Excluir(Id);

            return Ok(result);
        }
    }
}
