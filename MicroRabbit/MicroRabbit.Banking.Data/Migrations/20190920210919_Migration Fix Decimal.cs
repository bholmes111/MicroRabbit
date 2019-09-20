using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Banking.Data.Migrations
{
    public partial class MigrationFixDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AccountBalance",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AccountBalance",
                table: "Accounts",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
