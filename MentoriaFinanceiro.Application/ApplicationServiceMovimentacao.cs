using MentoriaFinanceiro.Application.Dtos;
using MentoriaFinanceiro.Application.Interfaces;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application
{
    public class ApplicationServiceMovimentacao : IApplicationServiceMovimentacao
    {
        private readonly IServiceMovimentacao serviceMovimentacao;
        private readonly IMapperMovimentacao mapperMovimentacao;

        public ApplicationServiceMovimentacao(IServiceMovimentacao serviceMovimentacao, IMapperMovimentacao mapperMovimentacao)
        {
            this.serviceMovimentacao = serviceMovimentacao;
            this.mapperMovimentacao = mapperMovimentacao;
        }

        public void Add(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = mapperMovimentacao.MapperDtoToEntity(movimentacaoDto);
            serviceMovimentacao.Add(movimentacao);
        }

        public IEnumerable<MovimentacaoDto> GetAll()
        {
            var movimentacoes = serviceMovimentacao.GetAll();
            return mapperMovimentacao.MapperListMovimentacoesDto(movimentacoes);

        }

        public MovimentacaoDto GetById(int id)
        {
            var movimentacao = serviceMovimentacao.GetById(id);
            return mapperMovimentacao.MapperEntityToDto(movimentacao);
        }

        public void Remove(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = mapperMovimentacao.MapperDtoToEntity(movimentacaoDto);
            serviceMovimentacao.Remove(movimentacao);
        }

        public void Update(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = mapperMovimentacao.MapperDtoToEntity(movimentacaoDto);
            serviceMovimentacao.Remove(movimentacao);
        }
    }
}
