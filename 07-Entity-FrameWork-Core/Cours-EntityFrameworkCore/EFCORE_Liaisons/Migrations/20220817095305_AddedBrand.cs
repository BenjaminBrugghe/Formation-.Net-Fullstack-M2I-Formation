using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_Liaisons.Migrations
{
    public partial class AddedBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Toys_ToyId",
                table: "Dogs");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Toys",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ToyId",
                table: "Dogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Toys_BrandId",
                table: "Toys",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Toys_ToyId",
                table: "Dogs",
                column: "ToyId",
                principalTable: "Toys",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Toys_Brands_BrandId",
                table: "Toys",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Toys_ToyId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Toys_Brands_BrandId",
                table: "Toys");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Toys_BrandId",
                table: "Toys");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Toys");

            migrationBuilder.AlterColumn<int>(
                name: "ToyId",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Toys_ToyId",
                table: "Dogs",
                column: "ToyId",
                principalTable: "Toys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
