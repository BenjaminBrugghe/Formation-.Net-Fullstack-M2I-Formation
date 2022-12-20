using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_VideoStore.Migrations
{
    public partial class IHM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Clients",
                newName: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "lastName");
        }
    }
}
