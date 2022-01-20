using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorPostgreSQL.Server.Migrations
{
    public partial class MuchosMuchos : Migration
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

            migrationBuilder.CreateTable(
                name: "EmpleadoEntidad",
                columns: table => new
                {
                    empleadoscodigo = table.Column<string>(type: "text", nullable: false),
                    entidadescodigo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoEntidad", x => new { x.empleadoscodigo, x.entidadescodigo });
                    table.ForeignKey(
                        name: "FK_EmpleadoEntidad_Empleados_empleadoscodigo",
                        column: x => x.empleadoscodigo,
                        principalTable: "Empleados",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpleadoEntidad_Entidades_entidadescodigo",
                        column: x => x.entidadescodigo,
                        principalTable: "Entidades",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoEntidad_entidadescodigo",
                table: "EmpleadoEntidad",
                column: "entidadescodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpleadoEntidad");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Entidades");
        }
    }
}
