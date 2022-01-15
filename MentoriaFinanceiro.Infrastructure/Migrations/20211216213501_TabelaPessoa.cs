using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MentoriaFinanceiro.API.Migrations
{
    public partial class TabelaPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "financeiro");

            migrationBuilder.CreateTable(
                name: "tb_pessoa_fisica",
                schema: "financeiro",
                columns: table => new
                {
                    cod_seq_pessoa_fisica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no_pessoa = table.Column<string>(nullable: true),
                    nu_cpf = table.Column<string>(nullable: true),
                    dt_nascimento = table.Column<DateTime>(nullable: true),
                    nu_sexo = table.Column<string>(nullable: false),
                    st_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_pessoa_fisica", x => x.cod_seq_pessoa_fisica);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_pessoa_fisica",
                schema: "financeiro");
        }
    }
}
