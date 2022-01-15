using System;

namespace MentoriaFinanceiro.Application.Dtos
{
    public class ContaDto
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public DateTime? DataAbertura { get; set; }
        public decimal ValorAbertura { get; set; }
        public decimal ValorSaldoAtual { get; set; }
        public DateTime? DataUltimaMovimentacao { get; set; }
        public bool Ativo { get; set; }

    }
}
