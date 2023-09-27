using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class scores3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_AspNetUsers_ApplicationUserId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_MathQuestions_MathQuestionQuestionID",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_MathQuestionQuestionID",
                table: "Scores");

            migrationBuilder.RenameColumn(
                name: "MathQuestionQuestionID",
                table: "Scores",
                newName: "PossiblePoints");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Scores",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_ApplicationUserId",
                table: "Scores",
                newName: "IX_Scores_UserId");

            migrationBuilder.AddColumn<int>(
                name: "CorrectPoints",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_AspNetUsers_UserId",
                table: "Scores",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_AspNetUsers_UserId",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "CorrectPoints",
                table: "Scores");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Scores",
                newName: "ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "PossiblePoints",
                table: "Scores",
                newName: "MathQuestionQuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_UserId",
                table: "Scores",
                newName: "IX_Scores_ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_MathQuestionQuestionID",
                table: "Scores",
                column: "MathQuestionQuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_AspNetUsers_ApplicationUserId",
                table: "Scores",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_MathQuestions_MathQuestionQuestionID",
                table: "Scores",
                column: "MathQuestionQuestionID",
                principalTable: "MathQuestions",
                principalColumn: "QuestionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
