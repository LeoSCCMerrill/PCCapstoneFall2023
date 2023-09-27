using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class scores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MathQuestionQuestionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.ScoreID);
                    table.ForeignKey(
                        name: "FK_Scores_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_MathQuestions_MathQuestionQuestionID",
                        column: x => x.MathQuestionQuestionID,
                        principalTable: "MathQuestions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ApplicationUserId",
                table: "Scores",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_MathQuestionQuestionID",
                table: "Scores",
                column: "MathQuestionQuestionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
