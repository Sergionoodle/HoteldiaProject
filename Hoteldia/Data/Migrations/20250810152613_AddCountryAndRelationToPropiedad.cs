using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hoteldia.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryAndRelationToPropiedad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Propiedad",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propiedad_CountryId",
                table: "Propiedad",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedad_Country_CountryId",
                table: "Propiedad",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedad_Country_CountryId",
                table: "Propiedad");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Propiedad_CountryId",
                table: "Propiedad");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Propiedad");
        }
    }
}
