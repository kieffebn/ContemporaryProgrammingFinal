using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamNames",
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
                    table.PrimaryKey("PK_TeamNames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TeamNames",
                columns: new[] { "Id", "Birthday", "PersonName", "Program", "Year" },
                values: new object[] { 1, "06/09/1999", "Ben Kieffer", "Software Development", "Senior" });

            migrationBuilder.InsertData(
                table: "TeamNames",
                columns: new[] { "Id", "Birthday", "PersonName", "Program", "Year" },
                values: new object[] { 2, "03/12/1999", "Bob Jones", "Cybersecurity", "Senior" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamNames");
        }
    }
}
