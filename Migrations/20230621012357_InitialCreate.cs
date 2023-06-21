using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TreinoAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Repeticao = table.Column<int>(type: "int", nullable: false),
                    Execucao = table.Column<int>(type: "int", nullable: false),
                    TempoMin = table.Column<int>(type: "int", nullable: false),
                    Classe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercicios",
                columns: new[] { "Id", "Classe", "Execucao", "Nome", "Repeticao", "TempoMin" },
                values: new object[,]
                {
                    { 1, 2, 12, "Agachamento", 3, 0 },
                    { 2, 1, 15, "Supino", 3, 0 },
                    { 3, 7, 0, "Prancha", 0, 1 },
                    { 4, 8, 0, "Esteira", 0, 30 },
                    { 5, 5, 12, "Bíceps Rosca", 4, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercicios");
        }
    }
}
