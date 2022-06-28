using Microsoft.EntityFrameworkCore.Migrations;

namespace FlatRockTech_DataAccess.Migrations
{
    public partial class ChangeAnswerTypeEnumToString1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnswerTypeChoice",
                table: "AnswerTypes",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AnswerTypeChoice",
                table: "AnswerTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");
        }
    }
}
