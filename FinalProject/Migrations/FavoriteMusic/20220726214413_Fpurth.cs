using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.FavoriteMusic
{
    public partial class Fpurth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteSongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavSong1 = table.Column<string>(nullable: true),
                    FavSong2 = table.Column<string>(nullable: true),
                    FavSong3 = table.Column<string>(nullable: true),
                    FavSong4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSongs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteSongs",
                columns: new[] { "Id", "FavSong1", "FavSong2", "FavSong3", "FavSong4" },
                values: new object[] { 1, "Friends - Led Zeppelin", "Celebration Day - Led Zeppelin", "Jungle - ELO", "Tightrope - ELO" });

            migrationBuilder.InsertData(
                table: "FavoriteSongs",
                columns: new[] { "Id", "FavSong1", "FavSong2", "FavSong3", "FavSong4" },
                values: new object[] { 2, "Wild West Hero - ELO", "Running Up That Hill - Kate Bush", "Master of Puppets - Metallica", "Every Breath You Take - The Police" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteSongs");
        }
    }
}
