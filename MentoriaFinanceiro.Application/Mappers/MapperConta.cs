using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MentoriaFinanceiro.Application.Mappers
{
    public class MapperConta : IMapperConta
    {
        public Conta MapperDtoToEntity(ContaDto contaDto)
        {
           var conta = new Conta()
           {
               Id = contaDto.Id,
               PessoaId = contaDto.PessoaId,
               Agencia = contaDto.Agencia,
               ContaCorrente = contaDto.ContaCorrente,
               DataAbertura = contaDto.DataAbertura,
               ValorAbertura = contaDto.ValorAbertura,
               ValorSaldoAtual = contaDto.ValorSaldoAtual,
               DataUltimaMovimentacao = contaDto.DataUltimaMovimentacao,
               Ativo = contaDto.Ativo 
           };
           return conta;
        }

        public ContaDto MapperEntityToDto(Conta Conta)
        {
            var contaDto = new ContaDto()
            {
                Id = Conta.Id,
                PessoaId = Conta.PessoaId,
                Agencia = Conta.Agencia,
                ContaCorrente = Conta.ContaCorrente,
                DataAbertura = Conta.DataAbertura,
                ValorAbertura = Conta.ValorAbertura,
                ValorSaldoAtual = Conta.ValorSaldoAtual,
                DataUltimaMovimentacao = Conta.DataUltimaMovimentacao,
                Ativo = Conta.Ativo
            };
            return contaDto;
        }

        public IEnumerable<ContaDto> MapperListContaDto(IEnumerable<Conta> contas)
        {
            var dto = contas.Select(c => new ContaDto
            {
                Id = c.Id,
                PessoaId = c.PessoaId,
                Agencia = c.Agencia,
                ContaCorrente = c.ContaCorrente,
                DataAbertura = c.DataAbertura,
                ValorAbertura = c.ValorAbertura,
                ValorSaldoAtual = c.ValorSaldoAtual,
                DataUltimaMovimentacao = c.DataUltimaMovimentacao,
                Ativo = c.Ativo,
            });
            return dto;
        }
    }
}
