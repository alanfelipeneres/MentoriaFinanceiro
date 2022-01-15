using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentoriaFinanceiro.Domain.Entities
{

    [Table("tb_movimentacao", Schema = "financeiro")]
    public class Movimentacao 
    {
        [Column("cd_seq_movimentacao")]
        public int Id { get; set; }

        [Column("cd_conta_corrente")]
        public int ContaId { get; set; }
        public Conta Conta { get; set; }

        [Column("cd_operacao")]
        public int OperacaoId { get; set; }
        public Operacao Operacao { get; set; }

        [Column("dt_movimentacao")]
        public DateTime? DataMovimentacao { get; set; }

        [Column("nu_valor_movimento", TypeName = "decimal(10,2)")]
        public decimal ValorMovimentacao { get; set; }

        [Column("ds_descricao_movimento"), MaxLength(500)]
        public string DescricaoMovimentacao { get; set; }

        [Column("st_ativo")]
        public bool Ativo { get; set; }

    }
}
