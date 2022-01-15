using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MentoriaFinanceiro.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IApplicationServiceConta _applicationServiceConta;

        public ContaController(IApplicationServiceConta ApplicationServiceConta)
        {
            _applicationServiceConta = ApplicationServiceConta;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceConta.GetAll());
        }

        [HttpGet("{id}")]

        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceConta.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ContaDto contaDto)
        {
            try
            {
                if (contaDto == null)
                    return NotFound();
                _applicationServiceConta.Add(contaDto);
                return Ok("Cadastro de conta realizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ContaDto contaDto)
        {
            try
            {
                if (contaDto == null)
                    return NotFound();
                _applicationServiceConta.Update(contaDto);
                return Ok("Conta atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ContaDto contaDto)
        {
            try
            {
                if (contaDto == null)
                    return NotFound();
                _applicationServiceConta.Remove(contaDto);
                return Ok("Conta removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
