using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mycloud.Migrations
{
    public partial class StartMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conductors",
                columns: table => new
                {
                    ConductorId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductors", x => x.ConductorId);
                });

            migrationBuilder.CreateTable(
                name: "Insulators",
                columns: table => new
                {
                    InsulatorId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insulators", x => x.InsulatorId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CatalogueAddress = table.Column<string>(nullable: true),
                    CommercialName = table.Column<string>(nullable: true),
                    ConductorId = table.Column<int>(nullable: false),
                    GenericName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    InsulatorId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Conductors_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Conductors",
                        principalColumn: "ConductorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Insulators_InsulatorId",
                        column: x => x.InsulatorId,
                        principalTable: "Insulators",
                        principalColumn: "InsulatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ConductorId",
                table: "Products",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InsulatorId",
                table: "Products",
                column: "InsulatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Conductors");

            migrationBuilder.DropTable(
                name: "Insulators");
        }
    }
}
