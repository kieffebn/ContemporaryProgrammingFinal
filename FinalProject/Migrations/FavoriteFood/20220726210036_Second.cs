using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.FavoriteFood
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(nullable: true),
                    Birthday = table.Column<string>(nullable: true),
                    Program = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavBreak = table.Column<string>(nullable: true),
                    FavLunch = table.Column<string>(nullable: true),
                    FavDin = table.Column<string>(nullable: true),
                    FavDes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFood", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFood",
                columns: new[] { "Id", "FavBreak", "FavDes", "FavDin", "FavLunch" },
                values: new object[] { 1, "French Toast", "Cheesecake", "Pad Thai", "Pizza" });

            migrationBuilder.InsertData(
                table: "FavoriteFood",
                columns: new[] { "Id", "FavBreak", "FavDes", "FavDin", "FavLunch" },
                values: new object[] { 2, "Pancakes", "Brownies", "Spaghetti", "Subs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavFoods");

            migrationBuilder.DropTable(
                name: "FavoriteFood");
        }
    }
}
