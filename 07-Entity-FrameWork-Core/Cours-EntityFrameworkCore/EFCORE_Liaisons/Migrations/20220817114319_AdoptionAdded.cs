using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_Liaisons.Migrations
{
    public partial class AdoptionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogMaster");

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfAdoption = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoptions_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adoptions_Master_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_DogId",
                table: "Adoptions",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_MasterId",
                table: "Adoptions",
                column: "MasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.CreateTable(
                name: "DogMaster",
                columns: table => new
                {
                    DogsId = table.Column<int>(type: "int", nullable: false),
                    MastersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogMaster", x => new { x.DogsId, x.MastersId });
                    table.ForeignKey(
                        name: "FK_DogMaster_Dogs_DogsId",
                        column: x => x.DogsId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogMaster_Master_MastersId",
                        column: x => x.MastersId,
                        principalTable: "Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogMaster_MastersId",
                table: "DogMaster",
                column: "MastersId");
        }
    }
}
