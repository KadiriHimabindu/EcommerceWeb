using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceWeb.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "ListPrice", "MadeIn", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Nivea", "Keeps the body hydrated and it will nourish and make your body soft", 99.0, "India", 90.0, 80.0, 85.0, "Shower Gel" },
                    { 2, "Dazler", "best thing to paint your nail which will give elegant color to ur nails.which will make u more attractive", 100.0, "India", 80.0, 70.0, 75.0, "Nail Varnish" },
                    { 3, "Lakme", "Best product to make ur eyes more attractive", 150.0, "India", 140.0, 130.0, 135.0, "Eye Liner" },
                    { 4, "Mac matte", "Best thing which will add more colors to Lips and make u more beautiful", 300.0, "India", 250.0, 180.0, 200.0, "Lipstick" },
                    { 5, "Dermavive", "Keep your skin more soft and bright", 800.0, "India", 780.0, 700.0, 750.0, "Moisturizer" },
                    { 6, "Head and Shoulder", "Keep your hair dandruf free soft and silky", 200.0, "India", 180.0, 170.0, 175.0, "Shampoo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
