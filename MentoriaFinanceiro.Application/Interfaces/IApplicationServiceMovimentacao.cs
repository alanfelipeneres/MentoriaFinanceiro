using MentoriaFinanceiro.Application.Dtos;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application.Interfaces
{
    public interface IApplicationServiceMovimentacao
    {
        void Add(MovimentacaoDto movimentacaoDto);
        void Remove(MovimentacaoDto movimentacaoDto);
        void Update(MovimentacaoDto movimentacaoDto);
        IEnumerable<MovimentacaoDto> GetAll();
        MovimentacaoDto GetById(int id);
    }
}
