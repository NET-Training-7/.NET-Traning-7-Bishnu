﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class ProgramColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Program",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Program",
                table: "Students");
        }
    }
}
