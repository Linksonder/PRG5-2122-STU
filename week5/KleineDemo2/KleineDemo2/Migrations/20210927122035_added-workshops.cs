using Microsoft.EntityFrameworkCore.Migrations;

namespace KleineDemo2.Migrations
{
    public partial class addedworkshops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentWorkshop",
                columns: table => new
                {
                    StudentenStudentnummer = table.Column<int>(type: "int", nullable: false),
                    WorkshopsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentWorkshop", x => new { x.StudentenStudentnummer, x.WorkshopsId });
                    table.ForeignKey(
                        name: "FK_StudentWorkshop_Studenten_StudentenStudentnummer",
                        column: x => x.StudentenStudentnummer,
                        principalTable: "Studenten",
                        principalColumn: "Studentnummer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentWorkshop_Workshop_WorkshopsId",
                        column: x => x.WorkshopsId,
                        principalTable: "Workshop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentWorkshop_WorkshopsId",
                table: "StudentWorkshop",
                column: "WorkshopsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentWorkshop");

            migrationBuilder.DropTable(
                name: "Workshop");
        }
    }
}
