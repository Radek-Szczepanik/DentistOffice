using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistOffice.DataAccess.Migrations
{
    public partial class ChangeRelationsInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCards_UserCardId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserCardId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserCardId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_Users_UserId",
                table: "UserCards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_Users_UserId",
                table: "UserCards");

            migrationBuilder.DropIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserCards");

            migrationBuilder.AddColumn<int>(
                name: "UserCardId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCardId",
                table: "Users",
                column: "UserCardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCards_UserCardId",
                table: "Users",
                column: "UserCardId",
                principalTable: "UserCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
