using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;
using Microsoft.AspNetCore.Mvc;

namespace DevBr.Entrevista.Api.Controllers
{
    public class QuestionarioController : Controller
    {
        private readonly IQuestionarioAppService _service;

        public QuestionarioController(IQuestionarioAppService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(QuestionarioViewModel viewModel)
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
        public IActionResult Atualizar(QuestionarioViewModel viewModel)
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
