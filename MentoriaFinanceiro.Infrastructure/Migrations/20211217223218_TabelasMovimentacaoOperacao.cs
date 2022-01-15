using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MentoriaFinanceiro.API.Migrations
{
    public partial class TabelasMovimentacaoOperacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_opercao",
                schema: "financeiro",
                columns: table => new
                {
                    cd_seq_operacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no_operacao = table.Column<string>(nullable: true),
                    tp_movimentacao = table.Column<string>(nullable: false),
                    st_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_opercao", x => x.cd_seq_operacao);
                });

            migrationBuilder.CreateTable(
                name: "tb_movimentacao",
                schema: "financeiro",
                columns: table => new
                {
                    cd_seq_movimentacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cd_conta_corrente = table.Column<int>(nullable: false),
                    cd_operacao = table.Column<int>(nullable: false),
                    dt_movimentacao = table.Column<DateTime>(nullable: true),
                    nu_valor_movimento = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ds_descricao_movimento = table.Column<string>(maxLength: 500, nullable: true),
                    st_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_movimentacao", x => x.cd_seq_movimentacao);
                    table.ForeignKey(
                        name: "FK_tb_movimentacao_tb_conta_corrente_cd_conta_corrente",
                        column: x => x.cd_conta_corrente,
                        principalSchema: "financeiro",
                        principalTable: "tb_conta_corrente",
                        principalColumn: "cd_seq_conta_corrente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_movimentacao_tb_opercao_cd_operacao",
                        column: x => x.cd_operacao,
                        principalSchema: "financeiro",
                        principalTable: "tb_opercao",
                        principalColumn: "cd_seq_operacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_movimentacao_cd_conta_corrente",
                schema: "financeiro",
                table: "tb_movimentacao",
                column: "cd_conta_corrente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_movimentacao_cd_operacao",
                schema: "financeiro",
                table: "tb_movimentacao",
                column: "cd_operacao",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_movimentacao",
                schema: "financeiro");

            migrationBuilder.DropTable(
                name: "tb_opercao",
                schema: "financeiro");
        }
    }
}
