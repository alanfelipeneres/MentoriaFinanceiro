using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application
{
    public class ApplicationServicePessoa : IApplicationServicePessoa
    {
        private readonly IServicePessoa servicePessoa;
        private readonly IMapperPessoa mapperPessoa;

        public ApplicationServicePessoa(IServicePessoa servicePessoa, IMapperPessoa mapperPessoa)
        {
            this.servicePessoa = servicePessoa;
            this.mapperPessoa = mapperPessoa;
        }
        public void Add(PessoaDto pessoaDto)
        {
            var pessoa = mapperPessoa.MapperDtoToEntity(pessoaDto);
            servicePessoa.Add(pessoa);
        }

        public IEnumerable<PessoaDto> GetAll()
        {
            var pessoas = servicePessoa.GetAll();
            return mapperPessoa.MapperListPessoaDto(pessoas);
        }

        public PessoaDto GetById(int id)
        {
            var pessoas =  servicePessoa.GetById(id);
            return mapperPessoa.MapperEntityToDto(pessoas);
        }

        public void Remove(PessoaDto pessoaDto)
        {
            var pessoa = mapperPessoa.MapperDtoToEntity(pessoaDto);
            servicePessoa.Remove(pessoa);
        }

        public void Update(PessoaDto pessoaDto)
        {
            var pessoa = mapperPessoa.MapperDtoToEntity(pessoaDto);
            servicePessoa.Update(pessoa);
        }
    }
}
