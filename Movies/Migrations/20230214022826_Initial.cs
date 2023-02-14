using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Edited", "Lent", "Notes", "Rating" },
                values: new object[] { 1, false, "No", "Star Wars: Attack of the Clones", "PG" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Edited", "Lent", "Notes", "Rating" },
                values: new object[] { 2, false, "No", "Jojo Rabbit", "PG-13" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Edited", "Lent", "Notes", "Rating" },
                values: new object[] { 3, false, "No", "Interstellar", "PG-13" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
