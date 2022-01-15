using MentoriaFinanceiro.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaFinanceiro.Application.Interfaces
{
    public interface IApplicationServicePessoa
    {
        void Add(PessoaDto pessoaDto);
        void Update(PessoaDto pessoaDto);
        void Remove(PessoaDto pessoaDto);
        IEnumerable<PessoaDto> GetAll();
        PessoaDto GetById(int id);
    }
}
