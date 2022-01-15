using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MentoriaFinanceiro.API.Migrations
{
    public partial class TabelaConta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_conta_corrente",
                schema: "financeiro",
                columns: table => new
                {
                    cd_seq_conta_corrente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cd_pessoa_fisica = table.Column<int>(nullable: false),
                    ds_agencia = table.Column<string>(maxLength: 20, nullable: true),
                    ds_contacorrente = table.Column<string>(maxLength: 20, nullable: true),
                    dt_abertura = table.Column<DateTime>(nullable: true),
                    nu_valor_abertura = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    nu_saldo_atual = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    dt_ultima_movimentacao = table.Column<DateTime>(nullable: true),
                    st_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_conta_corrente", x => x.cd_seq_conta_corrente);
                    table.ForeignKey(
                        name: "FK_tb_conta_corrente_tb_pessoa_fisica_cd_pessoa_fisica",
                        column: x => x.cd_pessoa_fisica,
                        principalSchema: "financeiro",
                        principalTable: "tb_pessoa_fisica",
                        principalColumn: "cod_seq_pessoa_fisica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_conta_corrente_cd_pessoa_fisica",
                schema: "financeiro",
                table: "tb_conta_corrente",
                column: "cd_pessoa_fisica",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_conta_corrente",
                schema: "financeiro");
        }
    }
}
