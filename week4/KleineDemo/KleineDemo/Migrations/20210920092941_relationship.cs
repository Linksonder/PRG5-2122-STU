using Microsoft.EntityFrameworkCore.Migrations;

namespace KleineDemo.Migrations
{
    public partial class relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeroId",
                table: "Weapons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_HeroId",
                table: "Weapons",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Heroes_HeroId",
                table: "Weapons",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Heroes_HeroId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_HeroId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "Weapons");
        }
    }
}
