using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_VideoStore.Migrations
{
    public partial class modifTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpruntId",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Films_EmpruntId",
                table: "Films",
                column: "EmpruntId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Emprunts_EmpruntId",
                table: "Films",
                column: "EmpruntId",
                principalTable: "Emprunts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Emprunts_EmpruntId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_EmpruntId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "EmpruntId",
                table: "Films");
        }
    }
}
