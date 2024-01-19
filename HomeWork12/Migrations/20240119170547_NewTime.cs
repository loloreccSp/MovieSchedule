using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeWork12.Migrations
{
    /// <inheritdoc />
    public partial class NewTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "TimeMovies",
                table: "Movies",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeMovies",
                table: "Movies");
        }
    }
}
