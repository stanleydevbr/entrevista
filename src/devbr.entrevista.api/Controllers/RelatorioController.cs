﻿using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;
using Microsoft.AspNetCore.Mvc;

namespace DevBr.Entrevista.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatorioController : ControllerBase
    {
        
        
        private readonly IRelatorioAppService _service;

        public RelatorioController(IRelatorioAppService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(RelatorioViewModel viewModel)
        {
            var result = _service.Adicionar(viewModel);

            return Ok(result);
        }

        [HttpGet]
        public IActionResult Consultar(Guid Id)
        {
            var result = _service.Consultar(Id);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Atualizar(RelatorioViewModel viewModel)
        {
            var result = _service.Editar(viewModel);

            return Ok(result);
        }

        [HttpDelete]

        public IActionResult Deletar(Guid Id)
        {
            var result = _service.Excluir(Id);

            return Ok(result);
        }
    }
}
