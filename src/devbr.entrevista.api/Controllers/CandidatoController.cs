using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;
using Microsoft.AspNetCore.Mvc;

namespace DevBr.Entrevista.Api.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoAppService _service;

        public CandidatoController(ICandidatoAppService service)
        {
          _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CandidatoViewModel viewModel)
        {
//            return ModelState.IsValid ? TrateResultado(await _service.Adicionar(viewModel)) : BadRequest(ModelState);
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
        public IActionResult Atualizar([FromBody] CandidatoViewModel viewModel)
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
