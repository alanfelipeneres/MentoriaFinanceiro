using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaFinanceiro.Application.Interfaces.Mappers
{
    public interface IMapperConta 
    {
        Conta MapperDtoToEntity(ContaDto contaDto);
        IEnumerable<ContaDto> MapperListContaDto(IEnumerable<Conta> contas);
        ContaDto MapperEntityToDto(Conta conta);
    }
}
