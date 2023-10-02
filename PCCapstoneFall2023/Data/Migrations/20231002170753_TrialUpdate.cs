using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class TrialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_AspNetUsers_UserId",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrillContext",
                table: "DrillContext");

            migrationBuilder.RenameTable(
                name: "DrillContext",
                newName: "drillContext");

            migrationBuilder.RenameTable(
                name: "Score",
                newName: "Scores");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Scores",
                newName: "UserID");

            migrationBuilder.AddColumn<string>(
                name: "parentId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "teacherId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Scores",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreID",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CorrectPoints",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PossiblePoints",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_drillContext",
                table: "drillContext",
                column: "DrillQuestID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                column: "ScoreID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d6208e-e968-487e-a8f6-59a1c3ce94d7",
                column: "ConcurrencyStamp",
                value: "ad6c32f9-eb51-499e-bfbb-10264e5c1d49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4998520f-93b5-46c9-818c-122ae6a3796c",
                column: "ConcurrencyStamp",
                value: "d99a192e-1ffc-4fa3-bb26-7d9fb39f24d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "36410c82-d45b-4e2c-8583-b8e0b54cb431");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46f5809-0636-41b8-ba7a-f1f7d808769c",
                column: "ConcurrencyStamp",
                value: "68f7d9bb-857e-4415-aa1c-bb865edcfed5");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_UserID",
                table: "Scores",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_AspNetUsers_UserID",
                table: "Scores",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_AspNetUsers_UserID",
                table: "Scores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drillContext",
                table: "drillContext");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_UserID",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "parentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "teacherId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ScoreID",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "CorrectPoints",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "PossiblePoints",
                table: "Scores");

            migrationBuilder.RenameTable(
                name: "drillContext",
                newName: "DrillContext");

            migrationBuilder.RenameTable(
                name: "Scores",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Score",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Score",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrillContext",
                table: "DrillContext",
                column: "DrillQuestID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d6208e-e968-487e-a8f6-59a1c3ce94d7",
                column: "ConcurrencyStamp",
                value: "375189ca-4cab-4ad3-a118-dccc3b6a4821");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4998520f-93b5-46c9-818c-122ae6a3796c",
                column: "ConcurrencyStamp",
                value: "ffd4c51a-e79b-43fb-9ba5-d0c18b3244aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "f925122d-16fe-473d-9b78-de40c5581ab4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46f5809-0636-41b8-ba7a-f1f7d808769c",
                column: "ConcurrencyStamp",
                value: "5b49aae5-3267-464f-b4ed-dcd5d78b2ba9");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_AspNetUsers_UserId",
                table: "Score",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
