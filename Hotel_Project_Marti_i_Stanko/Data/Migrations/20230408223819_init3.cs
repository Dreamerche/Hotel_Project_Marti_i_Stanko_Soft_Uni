using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Project_Marti_i_Stanko.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "checkInDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "includingBreakfast",
                table: "Reservations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAllInclusive",
                table: "Reservations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "totalPrice",
                table: "Reservations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "vacatingDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checkInDate",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "includingBreakfast",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "isAllInclusive",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "vacatingDate",
                table: "Reservations");
        }
    }
}
