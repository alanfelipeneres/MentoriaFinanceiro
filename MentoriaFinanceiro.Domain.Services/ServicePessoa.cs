using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Domain.Services
{
    public class ServicePessoa : ServiceBase<Pessoa>, IServicePessoa
    {
        private readonly IRepositoryPessoa repositoryPessoa;

        public ServicePessoa(IRepositoryPessoa repositoryPessoa) : base(repositoryPessoa)
        {
            this.repositoryPessoa = repositoryPessoa;
        }
     }
}
