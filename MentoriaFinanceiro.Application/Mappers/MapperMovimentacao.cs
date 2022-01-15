using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MentoriaFinanceiro.Application.Mappers
{
    public class MapperMovimentacao : IMapperMovimentacao
    {
        public Movimentacao MapperDtoToEntity(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = new Movimentacao()
            {
                Id = movimentacaoDto.Id,
                ContaId = movimentacaoDto.ContaId,
                OperacaoId = movimentacaoDto.OperacaoId,
                DataMovimentacao = movimentacaoDto.DataMovimentacao,
                ValorMovimentacao = movimentacaoDto.ValorMovimentacao,
                DescricaoMovimentacao = movimentacaoDto.DescricaoMovimentacao,
                Ativo = movimentacaoDto.Ativo
            };
            return movimentacao;
        }

        public MovimentacaoDto MapperEntityToDto(Movimentacao movimentacao)
        {
            var movimentacaoDto = new MovimentacaoDto()
            {
                Id = movimentacao.Id,
                ContaId = movimentacao.ContaId,
                OperacaoId = movimentacao.OperacaoId,
                DataMovimentacao = movimentacao.DataMovimentacao,
                ValorMovimentacao = movimentacao.ValorMovimentacao,
                DescricaoMovimentacao = movimentacao.DescricaoMovimentacao,
                Ativo = movimentacao.Ativo
            };
            return movimentacaoDto;
        }

        public IEnumerable<MovimentacaoDto> MapperListMovimentacoesDto(IEnumerable<Movimentacao> movimentacoes)
        {
            var dto = movimentacoes.Select(
                c => new MovimentacaoDto()
                {
                    Id = c.Id,
                    ContaId = c.ContaId,
                    OperacaoId = c.OperacaoId,
                    DataMovimentacao = c.DataMovimentacao,
                    ValorMovimentacao = c.ValorMovimentacao,
                    DescricaoMovimentacao = c.DescricaoMovimentacao,
                    Ativo = c.Ativo
                }
                );
            return dto;
        }

    }
}
