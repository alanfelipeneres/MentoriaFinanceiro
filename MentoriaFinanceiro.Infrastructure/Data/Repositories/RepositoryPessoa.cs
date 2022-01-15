using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Infrastructure.Data.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        private readonly SqlContext sqlContext;

        public RepositoryPessoa (SqlContext sqlContext) : base (sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
