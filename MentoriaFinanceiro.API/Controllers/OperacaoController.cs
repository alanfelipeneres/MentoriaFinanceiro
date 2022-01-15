using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MentoriaFinanceiro.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperacaoController : ControllerBase
    {
        private readonly IApplicationServiceOperacao _applicationServiceOperacao;
        public OperacaoController(IApplicationServiceOperacao ApplicationServiceOperacao)
        {
            _applicationServiceOperacao = ApplicationServiceOperacao;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceOperacao.GetAll());
        }

        [HttpGet("{id}")]

        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceOperacao.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] OperacaoDto operacaoDto)
        {
            try
            {
                if (operacaoDto == null)
                    return NotFound();
                _applicationServiceOperacao.Add(operacaoDto);
                return Ok("Cadastro de operação realizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] OperacaoDto operacaoDto)
        {
            try
            {
                if (operacaoDto == null)
                    return NotFound();
                _applicationServiceOperacao.Update(operacaoDto);
                return Ok("Operação atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] OperacaoDto operacaoDto)
        {
            try
            {
                if (operacaoDto == null)
                    return NotFound();
                _applicationServiceOperacao.Remove(operacaoDto);
                return Ok("Operação removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
