using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_Liaisons.Migrations
{
    public partial class AddedMastersMtM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogMaster");

            migrationBuilder.DropTable(
                name: "Master");
        }
    }
}
