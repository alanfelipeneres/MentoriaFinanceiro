using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Infrastructure.Data.Repositories
{
    public class RepositoryOperacao : RepositoryBase<Operacao>, IRepositoryOperacao
    {
        private readonly SqlContext sqlContext;

        public RepositoryOperacao(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
