using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application
{
    public class ApplicationServiceOperacao : IApplicationServiceOperacao
    {
        private readonly IServiceOperacao serviceOperacao;
        private readonly IMapperOperacao mapperOperacao;

        public ApplicationServiceOperacao ( IServiceOperacao serviceOperacao, IMapperOperacao mapperOperacao)
        {
            this.serviceOperacao = serviceOperacao;
            this.mapperOperacao = mapperOperacao;
        }
        public void Add(OperacaoDto operacaoDto)
        {
           var operacao = mapperOperacao.MapperDtoToEntity(operacaoDto);
           serviceOperacao.Add(operacao);
        }

        public IEnumerable<OperacaoDto> GetAll()
        {
            var operacoes = serviceOperacao.GetAll();
            return mapperOperacao.MapperListOperacoesDto(operacoes);
        }

        public OperacaoDto GetById(int id)
        {
            var operacao = serviceOperacao.GetById(id);
            return mapperOperacao.MapperEntityToDto(operacao);
        }

        public void Remove(OperacaoDto operacaoDto)
        {
           var operacao = mapperOperacao.MapperDtoToEntity(operacaoDto);
           serviceOperacao.Remove(operacao);
        }

        public void Update(OperacaoDto operacaoDto)
        {
            var operacao = mapperOperacao.MapperDtoToEntity(operacaoDto);
            serviceOperacao.Remove(operacao);
        }
    }
}
