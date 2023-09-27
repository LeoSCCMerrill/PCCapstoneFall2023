using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class UpdatedTyps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_drillContext",
                table: "drillContext");

            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "drillContext",
                newName: "DrillContext");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "AspNetUsers",
                newName: "teacherId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "AspNetUsers",
                newName: "parentId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DrillContext",
                table: "DrillContext");

            migrationBuilder.RenameTable(
                name: "DrillContext",
                newName: "drillContext");

            migrationBuilder.RenameColumn(
                name: "teacherId",
                table: "AspNetUsers",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "parentId",
                table: "AspNetUsers",
                newName: "ParentId");

            migrationBuilder.AddColumn<int>(
                name: "AccountType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_drillContext",
                table: "drillContext",
                column: "DrillQuestID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d6208e-e968-487e-a8f6-59a1c3ce94d7",
                column: "ConcurrencyStamp",
                value: "bf8e62e3-2d88-4ad6-af1c-a2b590814421");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4998520f-93b5-46c9-818c-122ae6a3796c",
                column: "ConcurrencyStamp",
                value: "f48fb5b5-7ac4-4e4d-a696-0bfffaf95105");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "27d7c7e1-e3bc-426e-a212-31de0dd6ba9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46f5809-0636-41b8-ba7a-f1f7d808769c",
                column: "ConcurrencyStamp",
                value: "f6e5c25a-c3eb-4358-86dc-17a4c5663295");
        }
    }
}
