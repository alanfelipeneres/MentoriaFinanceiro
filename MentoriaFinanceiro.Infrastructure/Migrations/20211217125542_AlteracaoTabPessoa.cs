using Microsoft.EntityFrameworkCore.Migrations;

namespace MentoriaFinanceiro.API.Migrations
{
    public partial class AlteracaoTabPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "nu_sexo",
                schema: "financeiro",
                table: "tb_pessoa_fisica",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "no_pessoa",
                schema: "financeiro",
                table: "tb_pessoa_fisica",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nu_cpf",
                schema: "financeiro",
                table: "tb_pessoa_fisica",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nu_sexo",
                schema: "financeiro",
                table: "tb_pessoa_fisica",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "no_pessoa",
                schema: "financeiro",
                table: "tb_pessoa_fisica",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nu_cpf",
                schema: "financeiro",
                table: "tb_pessoa_fisica",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11,
                oldNullable: true);
        }
    }
}
