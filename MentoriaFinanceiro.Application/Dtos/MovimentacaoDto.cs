using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaFinanceiro.Application.Dtos
{
    public class MovimentacaoDto 
    {
        public int Id { get; set; }
        public int ContaId { get; set; }
        public int OperacaoId { get; set; }
        public DateTime? DataMovimentacao { get; set; }
        public decimal ValorMovimentacao { get; set; }
        public string DescricaoMovimentacao { get; set; }
        public bool Ativo { get; set; }
    }
}
