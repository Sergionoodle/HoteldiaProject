﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hoteldia.Migrations
{
    /// <inheritdoc />
    public partial class AddImageTableWithRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagenPropiedad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropiedadId = table.Column<int>(type: "int", nullable: false),
                    UrlImagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenPropiedad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagenPropiedad_Propiedad_PropiedadId",
                        column: x => x.PropiedadId,
                        principalTable: "Propiedad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagenPropiedad_PropiedadId",
                table: "ImagenPropiedad",
                column: "PropiedadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenPropiedad");
        }
    }
}
