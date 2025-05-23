﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class _11thMig_LoanApprove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Loans",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Loans");
        }
    }
}
