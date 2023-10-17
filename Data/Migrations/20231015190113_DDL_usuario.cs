using Microsoft.EntityFrameworkCore.Migrations;

namespace Mediget_App.Data.Migrations
{
    public partial class DDL_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correoElectonico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cedulaIdentidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
