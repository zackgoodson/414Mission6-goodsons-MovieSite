using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "CategoryId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "CategoryId",
                value: 3);
        }
    }
}
