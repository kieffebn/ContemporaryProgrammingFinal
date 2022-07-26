using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.FavoriteVenue
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteVenues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavRestaraunt = table.Column<string>(nullable: true),
                    FavBar = table.Column<string>(nullable: true),
                    FavPark = table.Column<string>(nullable: true),
                    FavStadium = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteVenues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteVenues",
                columns: new[] { "Id", "FavBar", "FavPark", "FavRestaraunt", "FavStadium" },
                values: new object[] { 1, "Pins", "Ault Park", "Buca Di Beppo", "Great American Ballpark" });

            migrationBuilder.InsertData(
                table: "FavoriteVenues",
                columns: new[] { "Id", "FavBar", "FavPark", "FavRestaraunt", "FavStadium" },
                values: new object[] { 2, "Rosedale", "Washington Park", "Gomez", "TQL Stadium" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteVenues");
        }
    }
}
