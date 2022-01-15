using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MentoriaFinanceiro.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovimentacaoController : ControllerBase
    {
        private readonly IApplicationServiceMovimentacao _applicationServiceMovimentacao;

        public MovimentacaoController(IApplicationServiceMovimentacao ApplicationServiceConta)
        {
            _applicationServiceMovimentacao = ApplicationServiceConta;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceMovimentacao.GetAll());
        }

        [HttpGet("{id}")]

        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceMovimentacao.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] MovimentacaoDto movimentacaoDto)
        {
            try
            {
                if (movimentacaoDto == null)
                    return NotFound();
                _applicationServiceMovimentacao.Add(movimentacaoDto);
                return Ok("Cadastro de movimentação realizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] MovimentacaoDto movimentacaoDto)
        {
            try
            {
                if (movimentacaoDto == null)
                    return NotFound();
                _applicationServiceMovimentacao.Update(movimentacaoDto);
                return Ok("Movimentação atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] MovimentacaoDto movimentacaoDto)
        {
            try
            {
                if (movimentacaoDto == null)
                    return NotFound();
                _applicationServiceMovimentacao.Remove(movimentacaoDto);
                return Ok("Movimentação removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
