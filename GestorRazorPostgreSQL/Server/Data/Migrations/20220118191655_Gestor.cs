using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorPostgreSQL.Server.Migrations
{
    public partial class Gestor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: true),
                    estudios = table.Column<string>(type: "text", nullable: true),
                    fechanacimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "EntidadEmpleados",
                columns: table => new
                {
                    codigoentidad = table.Column<string>(type: "text", nullable: false),
                    codigoempleado = table.Column<string>(type: "text", nullable: true),
                    anios = table.Column<string>(type: "text", nullable: true),
                    fechaingresp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fecharetiro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cargo = table.Column<string>(type: "text", nullable: true),
                    area = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadEmpleados", x => x.codigoentidad);
                });

            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: true),
                    sector = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "EntidadEmpleados");

            migrationBuilder.DropTable(
                name: "Entidades");
        }
    }
}
