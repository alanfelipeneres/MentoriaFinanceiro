using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Entities;

namespace MentoriaFinanceiro.Infrastructure.Data.Repositories
{
    public class RepositoryMovimentacao : RepositoryBase<Movimentacao>, IRepositoryMovimentacao
    {
        private readonly SqlContext sqlContext;

        public RepositoryMovimentacao(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
