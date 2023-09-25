using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class InitialMath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MathQuestions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AskedQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<int>(type: "int", nullable: false),
                    PointsWorth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MathQuestions", x => x.QuestionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MathQuestions");
        }
    }
}
