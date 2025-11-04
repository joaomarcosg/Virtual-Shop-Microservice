using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO PRODUCTS(Name, Price, Description, Stock, ImageURL, CategoryID)" +
                "VALUES ('Caderno', 7.55, 'Caderno universitário', 10, 'caderno1.jpg', 1)"
            );

            migrationBuilder.Sql(
                "INSERT INTO PRODUCTS(Name, Price, Description, Stock, ImageURL, CategoryID)" +
                "VALUES ('Lápis', 3.45, 'Lápis preto', 20, 'lapis1.jpg', 1)"
            );

            migrationBuilder.Sql(
                "INSERT INTO PRODUCTS(Name, Price, Description, Stock, ImageURL, CategoryID)" +
                "VALUES ('Clips', 5.33, 'Clips para papel', 50, 'clips1.jpg', 2)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
