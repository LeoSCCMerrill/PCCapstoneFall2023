using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCCapstoneFall2023.Data.Migrations
{
    public partial class drillControllerFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drillContext");
        }
    }
}
