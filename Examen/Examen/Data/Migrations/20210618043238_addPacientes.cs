using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen.Data.Migrations
{
    public partial class addPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteNombre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcompNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcompApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteDireccionCalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteDireccionCalle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCodPostal = table.Column<int>(type: "int", nullable: false),
                    PacienteCodArea = table.Column<int>(type: "int", nullable: false),
                    PacienteTelefono = table.Column<int>(type: "int", nullable: false),
                    PacienteCodArea2 = table.Column<int>(type: "int", nullable: false),
                    PacienteWhatsapp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
