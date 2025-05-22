using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FahrtenbuchProjektCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CarType = table.Column<int>(type: "INTEGER", nullable: false),
                    LicencePlate = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Journeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JourneyDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeStampStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeStampEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TravelRoute = table.Column<int>(type: "INTEGER", nullable: false),
                    PurposeOfTheJourney = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    KmDistanceDeparture = table.Column<int>(type: "INTEGER", nullable: false),
                    KmDistanceArrival = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyCarId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journeys_CompanyCars_CompanyCarId",
                        column: x => x.CompanyCarId,
                        principalTable: "CompanyCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Journeys_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_CompanyCarId",
                table: "Journeys",
                column: "CompanyCarId");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_EmployeeId",
                table: "Journeys",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Journeys");

            migrationBuilder.DropTable(
                name: "CompanyCars");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
