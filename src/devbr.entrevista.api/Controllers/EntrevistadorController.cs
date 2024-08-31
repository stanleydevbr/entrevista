﻿using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DevBr.Entrevista.Api.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EntrevistadorController : ControllerBase
    {
            private readonly IEntrevistadorAppService _service;

            public EntrevistadorController(IEntrevistadorAppService service)
            {
                _service = service;
            }

            [HttpPost]
            public IActionResult Create([FromBody] EntrevistadorViewModel viewModel)
            {
                var result = _service.Adicionar(viewModel);

                var response = new ResponseResultCore<EntrevistadorViewModel>(HttpStatusCode.Created, result);
                return new ObjectResult(response) { StatusCode = (int)HttpStatusCode.Created };

            }

            [HttpGet("Listar")]
            public IActionResult Listar()
            {
                var result = _service.Listar().ToList();
                if (result == null)
                    return NoContent();

                var response = new ResponseResultCore<List<EntrevistadorViewModel>>(HttpStatusCode.OK, result);
                return Ok(response);
            }

            [HttpGet]
            public IActionResult Consultar([FromQuery] Guid Id)
            {
                var result = _service.Consultar(Id);

                if (result == null)
                    return NoContent();

                var response = new ResponseResultCore<EntrevistadorViewModel>(HttpStatusCode.OK, result);
                return Ok(response);
            }

            [HttpPut]
            public IActionResult Atualizar([FromBody] EntrevistadorViewModel viewModel)
            {
                var result = _service.Editar(viewModel);

                if (result == null)
                    return NotFound();

                var response = new ResponseResultCore<EntrevistadorViewModel>(HttpStatusCode.OK, result);
                return Ok(response);
            }

            [HttpDelete]

            public IActionResult Deletar([FromQuery] Guid Id)
            {
                var result = _service.Excluir(Id);

                if (!result)
                    return NotFound();

                var response = new ResponseResultCore<bool>(HttpStatusCode.OK, result);

                return Ok(response);
            }
        }
    }
