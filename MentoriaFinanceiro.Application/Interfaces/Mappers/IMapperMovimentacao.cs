using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaFinanceiro.Application.Interfaces.Mappers
{
    public interface IMapperMovimentacao
    {
        Movimentacao MapperDtoToEntity(MovimentacaoDto movimentacaoDto);
        IEnumerable<MovimentacaoDto> MapperListMovimentacoesDto(IEnumerable<Movimentacao> movimentacoes);
        MovimentacaoDto MapperEntityToDto(Movimentacao movimentacao);
    }
}
