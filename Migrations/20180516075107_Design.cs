using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mycloud.Migrations
{
    public partial class Design : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Designs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Designs_CountryId",
                table: "Designs",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Designs_Countries_CountryId",
                table: "Designs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Designs_Countries_CountryId",
                table: "Designs");

            migrationBuilder.DropIndex(
                name: "IX_Designs_CountryId",
                table: "Designs");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Designs");
        }
    }
}
