using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;
using Microsoft.AspNetCore.Mvc;

namespace DevBr.Entrevista.Api.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly ICandidatoAppService _service;

        public CandidatoController(ICandidatoAppService service)
        {
          _service = service;
        }

        [HttpPost]
        public IActionResult Create(CandidatoViewModel viewModel)
        {
            var result = _service.Adicionar(viewModel);

            return View(result);
        }

        [HttpGet]
        public IActionResult Consultar(Guid Id)
        {
            var result = _service.Consultar(Id);

            return View(result);
        }

        [HttpPut]
        public IActionResult Atualizar(CandidatoViewModel viewModel)
        {
            var result = _service.Editar(viewModel);

            return View(result);
        }

        [HttpDelete]

        public IActionResult Deletar(Guid Id)
        {
            var result = _service.Excluir(Id);

            return View(result);
        }




    }
}
