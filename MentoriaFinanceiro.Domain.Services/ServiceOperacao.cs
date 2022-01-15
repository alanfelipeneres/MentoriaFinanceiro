using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Domain.Services
{
    public class ServiceOperacao : ServiceBase<Operacao>, IServiceOperacao
    {
        private readonly IRepositoryOperacao repositoryOperacao;

        public ServiceOperacao(IRepositoryOperacao repositoryOperacao) : base(repositoryOperacao)
        {
            this.repositoryOperacao = repositoryOperacao;
        }
    }
}
