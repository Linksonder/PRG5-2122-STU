using Microsoft.EntityFrameworkCore.Migrations;

namespace KleineDemo.Migrations
{
    public partial class catchphrase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Catchphrase",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Catchphrase",
                table: "Heroes");
        }
    }
}
