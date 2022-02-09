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
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    StreetNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    PostCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "UserCards",
                columns: table => new
                {
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsAllergy = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDiabetes = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsHypertension = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsHeartDiseases = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsJaundice = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPregnancy = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCough = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsQuarantine = table.Column<bool>(type: "INTEGER", nullable: false),
                    BodyTemperature = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCards", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserAddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserCardId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.MyProperty);
                    table.ForeignKey(
                        name: "FK_Users_UserAddresses_UserAddressId",
                        column: x => x.UserAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserCards_UserCardId",
                        column: x => x.UserCardId,
                        principalTable: "UserCards",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserContacts_UserContactId",
                        column: x => x.UserContactId,
                        principalTable: "UserContacts",
                        principalColumn: "MyProperty",
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
