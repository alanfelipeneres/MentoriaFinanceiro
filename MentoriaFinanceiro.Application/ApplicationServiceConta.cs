using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application
{
    public class ApplicationServiceConta : IApplicationServiceConta
    {
        private readonly IServiceConta serviceConta;
        private readonly IMapperConta mapperConta;

        public ApplicationServiceConta (IServiceConta serviceConta, IMapperConta mapperConta)
        {
            this.serviceConta = serviceConta;
            this.mapperConta = mapperConta;
        }

        public void Add(ContaDto contaDto)
        {
           var conta = mapperConta.MapperDtoToEntity(contaDto);
           serviceConta.Add(conta);
        }
        public IEnumerable<ContaDto> GetAll()
        {
            var contas = serviceConta.GetAll();
            return mapperConta.MapperListContaDto(contas);
        }

        public ContaDto GetById(int id)
        {
            var contas = serviceConta.GetById(id);
            return mapperConta.MapperEntityToDto(contas);
        }

        public void Remove(ContaDto contaDto)
        {
            var pessoa = mapperConta.MapperDtoToEntity(contaDto);
            serviceConta.Remove(pessoa);
        }

        public void Update(ContaDto contaDto)
        {
            var conta = mapperConta.MapperDtoToEntity(contaDto);
            serviceConta.Update(conta);
        }
    }
}
