using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mycloud.Migrations
{
    public partial class M001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
              //  name: "FK_Products_VoltageClass_VoltageClassId",
                //table: "Products");

            //migrationBuilder.DropPrimaryKey(
              //  name: "PK_VoltageClass",
                //table: "VoltageClass");

            //migrationBuilder.RenameTable(
             //   name: "VoltageClass",
               // newName: "VoltageClasses");

//            migrationBuilder.AddPrimaryKey(
  //              name: "PK_VoltageClasses",
    //            table: "VoltageClasses",
      //          column: "VoltageClassId");

            migrationBuilder.CreateTable(
                name: "Installation1s",
                columns: table => new
                {
                    Installation1Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installation1s", x => x.Installation1Id);
                });

            migrationBuilder.CreateTable(
                name: "Installation2s",
                columns: table => new
                {
                    Installation2Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installation2s", x => x.Installation2Id);
                });

            migrationBuilder.CreateTable(
                name: "Installation3s",
                columns: table => new
                {
                    Installation3Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installation3s", x => x.Installation3Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkCableInstallations",
                columns: table => new
                {
                    LinkCableInstallationId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CountryId = table.Column<int>(nullable: false),
                    Installation1Id = table.Column<int>(nullable: false),
                    Installation2Id = table.Column<int>(nullable: false),
                    Installation3Id = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkCableInstallations", x => x.LinkCableInstallationId);
                    table.ForeignKey(
                        name: "FK_LinkCableInstallations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkCableInstallations_Installation1s_Installation1Id",
                        column: x => x.Installation1Id,
                        principalTable: "Installation1s",
                        principalColumn: "Installation1Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkCableInstallations_Installation2s_Installation2Id",
                        column: x => x.Installation2Id,
                        principalTable: "Installation2s",
                        principalColumn: "Installation2Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkCableInstallations_Installation3s_Installation3Id",
                        column: x => x.Installation3Id,
                        principalTable: "Installation3s",
                        principalColumn: "Installation3Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkCableInstallations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkCableInstallations_CountryId",
                table: "LinkCableInstallations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCableInstallations_Installation1Id",
                table: "LinkCableInstallations",
                column: "Installation1Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCableInstallations_Installation2Id",
                table: "LinkCableInstallations",
                column: "Installation2Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCableInstallations_Installation3Id",
                table: "LinkCableInstallations",
                column: "Installation3Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCableInstallations_ProductId",
                table: "LinkCableInstallations",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VoltageClasses_VoltageClassId",
                table: "Products",
                column: "VoltageClassId",
                principalTable: "VoltageClasses",
                principalColumn: "VoltageClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VoltageClasses_VoltageClassId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "LinkCableInstallations");

            migrationBuilder.DropTable(
                name: "Installation1s");

            migrationBuilder.DropTable(
                name: "Installation2s");

            migrationBuilder.DropTable(
                name: "Installation3s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VoltageClasses",
                table: "VoltageClasses");

            migrationBuilder.RenameTable(
                name: "VoltageClasses",
                newName: "VoltageClass");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VoltageClass",
                table: "VoltageClass",
                column: "VoltageClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VoltageClass_VoltageClassId",
                table: "Products",
                column: "VoltageClassId",
                principalTable: "VoltageClass",
                principalColumn: "VoltageClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
