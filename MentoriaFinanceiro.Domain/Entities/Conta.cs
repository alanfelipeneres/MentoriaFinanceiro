using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentoriaFinanceiro.Domain.Entities
{
    [Table("tb_conta_corrente", Schema = "financeiro")]
    public class Conta
    {
        [Column("cd_seq_conta_corrente")]
        public int Id { get; set; }

        [Column("cd_pessoa_fisica")]
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        [Column("ds_agencia"), MaxLength(20)]
        public string Agencia { get; set; }

        [Column("ds_contacorrente"), MaxLength(20)]
        public string ContaCorrente { get; set; }

        [Column("dt_abertura")]
        public DateTime? DataAbertura { get; set; }

        [Column("nu_valor_abertura", TypeName = "decimal(10,2)")]
        public decimal ValorAbertura { get; set; }

        [Column("nu_saldo_atual", TypeName = "decimal(10,2)")]
        public decimal ValorSaldoAtual { get; set; }

        [Column("dt_ultima_movimentacao")]
        public DateTime? DataUltimaMovimentacao { get; set; }

        [Column("st_ativo")]
        public bool Ativo { get; set; }

        // relação com a entidade Movimentação 
        public Movimentacao Movimentacao { get; set; }

    }
}
