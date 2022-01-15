using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaFinanceiro.Application.Dtos
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int Sexo { get; set; }
        public bool Ativo { get; set; }

    }
}
