using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistOffice.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAllergy = table.Column<bool>(type: "bit", nullable: false),
                    IsDiabetes = table.Column<bool>(type: "bit", nullable: false),
                    IsHypertension = table.Column<bool>(type: "bit", nullable: false),
                    IsHeartDiseases = table.Column<bool>(type: "bit", nullable: false),
                    IsJaundice = table.Column<bool>(type: "bit", nullable: false),
                    IsPregnancy = table.Column<bool>(type: "bit", nullable: false),
                    IsCough = table.Column<bool>(type: "bit", nullable: false),
                    IsQuarantine = table.Column<bool>(type: "bit", nullable: false),
                    BodyTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddressId = table.Column<int>(type: "int", nullable: false),
                    UserContactId = table.Column<int>(type: "int", nullable: false),
                    UserCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserAddresses_UserAddressId",
                        column: x => x.UserAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserCards_UserCardId",
                        column: x => x.UserCardId,
                        principalTable: "UserCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserContacts_UserContactId",
                        column: x => x.UserContactId,
                        principalTable: "UserContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserAddressId",
                table: "Users",
                column: "UserAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCardId",
                table: "Users",
                column: "UserCardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserContactId",
                table: "Users",
                column: "UserContactId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserCards");

            migrationBuilder.DropTable(
                name: "UserContacts");
        }
    }
}
