using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Domain.Services
{
    public class ServiceMovimentacao : ServiceBase<Movimentacao> , IServiceMovimentacao
    {
        private readonly IRepositoryMovimentacao repositoryMovimentacao;
        public ServiceMovimentacao(IRepositoryMovimentacao repositoryMovimentacao) : base(repositoryMovimentacao)
        {
            this.repositoryMovimentacao = repositoryMovimentacao;
        }
    }
}
