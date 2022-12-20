using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_Liaisons.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ToyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dogs_Toys_ToyId",
                        column: x => x.ToyId,
                        principalTable: "Toys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    // Les options pour la suppression de la jointure 
                    //
                    // SetNull : Donner la valeur null dans la colonne de la clé étrangère
                    // NoAction : Ne rien faire au niveau de la BdD
                    // SetDefault : Donner la valeur par défaut de la clé étrangère dans la table
                    // Restrict : Empêcher la suppression de la jointure en cas d'animal utilisant le jouet
                    // Cascade : Supprimer les animaux pouvant avoir utilisé ce jouet et donc posséder la jointure en BdD
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ToyId",
                table: "Dogs",
                column: "ToyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Toys");
        }
    }
}
