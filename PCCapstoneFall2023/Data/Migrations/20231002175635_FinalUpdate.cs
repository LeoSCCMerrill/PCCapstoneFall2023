using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class FinalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_testQuestions",
                table: "testQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drillContext",
                table: "drillContext");

            migrationBuilder.RenameTable(
                name: "testQuestions",
                newName: "TestQuestions");

            migrationBuilder.RenameTable(
                name: "drillContext",
                newName: "DrillContext");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestQuestions",
                table: "TestQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrillContext",
                table: "DrillContext",
                column: "DrillQuestID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d6208e-e968-487e-a8f6-59a1c3ce94d7",
                column: "ConcurrencyStamp",
                value: "dfe8e186-39e5-413b-916f-174fd634cf05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4998520f-93b5-46c9-818c-122ae6a3796c",
                column: "ConcurrencyStamp",
                value: "ffe9de4f-5005-4c1f-bca7-4d4f346a2957");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "fb8c7dec-108d-4883-8ceb-bbcc17946d5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46f5809-0636-41b8-ba7a-f1f7d808769c",
                column: "ConcurrencyStamp",
                value: "97ac1376-9b48-4127-9007-bb90ac85c75a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestQuestions",
                table: "TestQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrillContext",
                table: "DrillContext");

            migrationBuilder.RenameTable(
                name: "TestQuestions",
                newName: "testQuestions");

            migrationBuilder.RenameTable(
                name: "DrillContext",
                newName: "drillContext");

            migrationBuilder.AddPrimaryKey(
                name: "PK_testQuestions",
                table: "testQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drillContext",
                table: "drillContext",
                column: "DrillQuestID");

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
        }
    }
}
