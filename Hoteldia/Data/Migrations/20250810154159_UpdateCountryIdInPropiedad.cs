using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hoteldia.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCountryIdInPropiedad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Propiedad SET CountryId = 57 WHERE Id IN (22, 24)");
            migrationBuilder.Sql("UPDATE Propiedad SET CountryId = 167 WHERE Id = 23");
            migrationBuilder.Sql("UPDATE Propiedad SET CountryId = 91 WHERE Id IN (25, 26)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Propiedad SET CountryId = NULL");
        }
    }
}
