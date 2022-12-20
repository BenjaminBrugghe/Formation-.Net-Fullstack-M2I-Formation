using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_Liaisons.Migrations
{
    public partial class ManyToysForADog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Toys_ToyId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_ToyId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "ToyId",
                table: "Dogs");

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "Toys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toys_DogId",
                table: "Toys",
                column: "DogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toys_Dogs_DogId",
                table: "Toys",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete : ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toys_Dogs_DogId",
                table: "Toys");

            migrationBuilder.DropIndex(
                name: "IX_Toys_DogId",
                table: "Toys");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "Toys");

            migrationBuilder.AddColumn<int>(
                name: "ToyId",
                table: "Dogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ToyId",
                table: "Dogs",
                column: "ToyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Toys_ToyId",
                table: "Dogs",
                column: "ToyId",
                principalTable: "Toys",
                principalColumn: "Id");
        }
    }
}
