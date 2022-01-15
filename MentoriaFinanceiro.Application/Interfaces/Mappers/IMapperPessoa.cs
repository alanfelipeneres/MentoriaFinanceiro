using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Domain.Entities;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application.Interfaces.Mappers
{
    public interface IMapperPessoa
    {
        Pessoa MapperDtoToEntity(PessoaDto pessoaDto);
        IEnumerable<PessoaDto> MapperListPessoaDto(IEnumerable<Pessoa> pessoas);
        PessoaDto MapperEntityToDto(Pessoa pessoa);
    }
}
