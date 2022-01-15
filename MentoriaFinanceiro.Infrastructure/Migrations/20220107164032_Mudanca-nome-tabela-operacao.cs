using Microsoft.EntityFrameworkCore.Migrations;

namespace MentoriaFinanceiro.API.Migrations
{
    public partial class Mudancanometabelaoperacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_movimentacao_tb_opercao_cd_operacao",
                schema: "financeiro",
                table: "tb_movimentacao");

            migrationBuilder.DropTable(
                name: "tb_opercao",
                schema: "financeiro");

            migrationBuilder.CreateTable(
                name: "tb_operacao",
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
                    table.PrimaryKey("PK_tb_operacao", x => x.cd_seq_operacao);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tb_movimentacao_tb_operacao_cd_operacao",
                schema: "financeiro",
                table: "tb_movimentacao",
                column: "cd_operacao",
                principalSchema: "financeiro",
                principalTable: "tb_operacao",
                principalColumn: "cd_seq_operacao",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_movimentacao_tb_operacao_cd_operacao",
                schema: "financeiro",
                table: "tb_movimentacao");

            migrationBuilder.DropTable(
                name: "tb_operacao",
                schema: "financeiro");

            migrationBuilder.CreateTable(
                name: "tb_opercao",
                schema: "financeiro",
                columns: table => new
                {
                    cd_seq_operacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    st_ativo = table.Column<bool>(type: "bit", nullable: false),
                    no_operacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tp_movimentacao = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_opercao", x => x.cd_seq_operacao);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tb_movimentacao_tb_opercao_cd_operacao",
                schema: "financeiro",
                table: "tb_movimentacao",
                column: "cd_operacao",
                principalSchema: "financeiro",
                principalTable: "tb_opercao",
                principalColumn: "cd_seq_operacao",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
