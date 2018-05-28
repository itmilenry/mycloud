using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mycloud.Migrations
{
    public partial class OtherAttributes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CableRangeId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CprClassId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsArmoured",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoltageClassId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CableRanges",
                columns: table => new
                {
                    CableRangeId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CountryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CableRanges", x => x.CableRangeId);
                    table.ForeignKey(
                        name: "FK_CableRanges_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CprClasses",
                columns: table => new
                {
                    CprClassId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CprClasses", x => x.CprClassId);
                });

            migrationBuilder.CreateTable(
                name: "VoltageClass",
                columns: table => new
                {
                    VoltageClassId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltageClass", x => x.VoltageClassId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CableRangeId",
                table: "Products",
                column: "CableRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CprClassId",
                table: "Products",
                column: "CprClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VoltageClassId",
                table: "Products",
                column: "VoltageClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CableRanges_CountryId",
                table: "CableRanges",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CableRanges_CableRangeId",
                table: "Products",
                column: "CableRangeId",
                principalTable: "CableRanges",
                principalColumn: "CableRangeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CprClasses_CprClassId",
                table: "Products",
                column: "CprClassId",
                principalTable: "CprClasses",
                principalColumn: "CprClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VoltageClass_VoltageClassId",
                table: "Products",
                column: "VoltageClassId",
                principalTable: "VoltageClass",
                principalColumn: "VoltageClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CableRanges_CableRangeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CprClasses_CprClassId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_VoltageClass_VoltageClassId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CableRanges");

            migrationBuilder.DropTable(
                name: "CprClasses");

            migrationBuilder.DropTable(
                name: "VoltageClass");

            migrationBuilder.DropIndex(
                name: "IX_Products_CableRangeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CprClassId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VoltageClassId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CableRangeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CprClassId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsArmoured",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VoltageClassId",
                table: "Products");
        }
    }
}
