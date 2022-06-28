using Microsoft.EntityFrameworkCore.Migrations;

namespace FlatRockTech_DataAccess.Migrations
{
    public partial class AddAnsertTypeTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnswerType",
                table: "Answers",
                newName: "AnswerType_Id");

            migrationBuilder.CreateTable(
                name: "AnswerTypes",
                columns: table => new
                {
                    AnswerType_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerTypeChoice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerTypes", x => x.AnswerType_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_AnswerType_Id",
                table: "Answers",
                column: "AnswerType_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AnswerTypes_AnswerType_Id",
                table: "Answers",
                column: "AnswerType_Id",
                principalTable: "AnswerTypes",
                principalColumn: "AnswerType_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AnswerTypes_AnswerType_Id",
                table: "Answers");

            migrationBuilder.DropTable(
                name: "AnswerTypes");

            migrationBuilder.DropIndex(
                name: "IX_Answers_AnswerType_Id",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "AnswerType_Id",
                table: "Answers",
                newName: "AnswerType");
        }
    }
}
