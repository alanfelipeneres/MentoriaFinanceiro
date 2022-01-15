using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentoriaFinanceiro.Domain.Entities
{
    [Table("tb_pessoa_fisica", Schema = "financeiro")]
    public class Pessoa
    {

        [Column("cod_seq_pessoa_fisica")]
        public int Id { get; set; }

        [Column("no_pessoa"), MaxLength(200)]
        public string Nome { get; set; }

        [Column("nu_cpf"), MaxLength(11)]
        public string Cpf { get; set; }

        [Column("dt_nascimento")]
        public DateTime? DataNascimento { get; set; }
        [Column("nu_sexo")]
        public int Sexo { get; set; }

        [Column("st_ativo")]
        public bool Ativo { get; set; }

        // relação com a entidade conta 
        public Conta Conta { get; set; }

    }
}
