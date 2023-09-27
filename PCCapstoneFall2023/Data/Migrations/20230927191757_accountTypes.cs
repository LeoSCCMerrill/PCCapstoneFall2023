using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class accountTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParentId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "drillContext",
                columns: table => new
                {
                    DrillQuestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrillDifficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrillLength = table.Column<int>(type: "int", nullable: false),
                    DrillRandomized = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrillTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    answer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drillContext", x => x.DrillQuestID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22d6208e-e968-487e-a8f6-59a1c3ce94d7", "bf8e62e3-2d88-4ad6-af1c-a2b590814421", "Student", "STUDENT" },
                    { "4998520f-93b5-46c9-818c-122ae6a3796c", "f48fb5b5-7ac4-4e4d-a696-0bfffaf95105", "Teacher", "TEACHER" },
                    { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", "27d7c7e1-e3bc-426e-a212-31de0dd6ba9e", "Administrator", "ADMINISTRATOR" },
                    { "e46f5809-0636-41b8-ba7a-f1f7d808769c", "f6e5c25a-c3eb-4358-86dc-17a4c5663295", "Parent", "PARENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeacherId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", 0, 0, "c8554266-b401-4519-9aeb-a9283053fc58", "ApplicationUser", "admin@myemail.com", true, false, null, "ADMIN@MYEMAIL.COM", "ADMIN@MYEMAIL.COM", null, "AQAAAAEAACcQAAAAEALfXOO0MYDpnaWi+2TO6u67hE3xzrew03QVb8Vb3wTOdiKZzWGSm42SscHBRPRT0g==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", null, false, "admin@myemail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", "b4280b6a-0613-4cbd-a9e6-f1701e926e73" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drillContext");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d6208e-e968-487e-a8f6-59a1c3ce94d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4998520f-93b5-46c9-818c-122ae6a3796c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46f5809-0636-41b8-ba7a-f1f7d808769c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", "b4280b6a-0613-4cbd-a9e6-f1701e926e73" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73");

            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "AspNetUsers");
        }
    }
}
