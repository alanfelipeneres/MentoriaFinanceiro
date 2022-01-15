using MentoriaFinanceiro.Application.Dtos;
using System.Collections.Generic;

namespace MentoriaFinanceiro.Application.Interfaces
{
    public interface IApplicationServiceOperacao
    {
        void Add(OperacaoDto operacaoDto);
        void Update(OperacaoDto operacaoDto);
        void Remove(OperacaoDto operacaoDto);
        IEnumerable<OperacaoDto> GetAll();
        OperacaoDto GetById(int id);
    }
}
