using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class author_table_update_popularity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestProperty",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "Popularity",
                table: "Authors",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "TestProperty",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
