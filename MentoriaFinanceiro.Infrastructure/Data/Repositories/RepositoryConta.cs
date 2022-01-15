using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Infrastructure.Data.Repositories
{
    public class RepositoryConta : RepositoryBase<Conta>, IRepositoryConta
    {
        private readonly SqlContext sqlContext;

        public RepositoryConta(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
