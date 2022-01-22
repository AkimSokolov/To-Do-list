using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketsAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubtaskModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TicketModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubtaskModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubtaskModel_TicketModel_TicketModelId",
                        column: x => x.TicketModelId,
                        principalTable: "TicketModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubtaskModel_TicketModelId",
                table: "SubtaskModel",
                column: "TicketModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubtaskModel");

            migrationBuilder.DropTable(
                name: "TicketModel");
        }
    }
}
