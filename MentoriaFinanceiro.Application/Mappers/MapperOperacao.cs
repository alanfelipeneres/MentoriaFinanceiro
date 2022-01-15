using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentoriaFinanceiro.Application.Mappers
{
    public class MapperOperacao : IMapperOperacao
    {
        public Operacao MapperDtoToEntity(OperacaoDto operacaoDto)
        {
            var operacao = new Operacao()
            {
                Id = operacaoDto.Id,
                NomeOperacao = operacaoDto.NomeOperacao,
                TipoMovimentacao = operacaoDto.TipoMovimentacao,
                Ativo = operacaoDto.Ativo
            };
           return operacao;
        }

        public OperacaoDto MapperEntityToDto(Operacao operacao)
        {
            var operacaoDto = new OperacaoDto()
            {
                Id = operacao.Id,
                NomeOperacao = operacao.NomeOperacao,
                TipoMovimentacao = operacao.TipoMovimentacao,
                Ativo = operacao.Ativo
            };
            return operacaoDto;
        }

        public IEnumerable<OperacaoDto> MapperListOperacoesDto(IEnumerable<Operacao> operacoes)
        {
            var dto = operacoes.Select( c => new OperacaoDto()
            {
                Id = c.Id,
                NomeOperacao = c.NomeOperacao,
                TipoMovimentacao = c.TipoMovimentacao,
                Ativo = c.Ativo
            });
            return dto;
        }

  
    }
}
