using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailWayWpfApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRailwayTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StansiyaNomi",
                table: "RailWayTables",
                newName: "Reys");

            migrationBuilder.AddColumn<DateTime>(
                name: "MahalliyVaqt",
                table: "RailWayTables",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MahalliyVaqt",
                table: "RailWayTables");

            migrationBuilder.RenameColumn(
                name: "Reys",
                table: "RailWayTables",
                newName: "StansiyaNomi");
        }
    }
}
