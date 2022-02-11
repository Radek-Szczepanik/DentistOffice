using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistOffice.DataAccess.Migrations
{
    public partial class UpdateEntityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "UserContacts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "UserCards",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "UserAddresses",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserContacts",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserCards",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserAddresses",
                newName: "MyProperty");
        }
    }
}
