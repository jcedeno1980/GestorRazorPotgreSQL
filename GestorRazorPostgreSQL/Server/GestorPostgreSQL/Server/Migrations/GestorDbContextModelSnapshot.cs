// <auto-generated />
using System;
using GestorPostgreSQL.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GestorPostgreSQL.Server.Migrations
{
    [DbContext(typeof(GestorDbContext))]
    partial class GestorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EmpleadoEntidad", b =>
                {
                    b.Property<string>("empleadoscodigo")
                        .HasColumnType("text");

                    b.Property<string>("entidadescodigo")
                        .HasColumnType("text");

                    b.HasKey("empleadoscodigo", "entidadescodigo");

                    b.HasIndex("entidadescodigo");

                    b.ToTable("EmpleadoEntidad");
                });

            modelBuilder.Entity("GestorPostgreSQL.Shared.Modelos.Empleado", b =>
                {
                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<string>("direccion")
                        .HasColumnType("text");

                    b.Property<string>("estudios")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechanacimiento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.HasKey("codigo");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("GestorPostgreSQL.Shared.Modelos.Entidad", b =>
                {
                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<string>("direccion")
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<string>("sector")
                        .HasColumnType("text");

                    b.HasKey("codigo");

                    b.ToTable("Entidades");
                });

            modelBuilder.Entity("EmpleadoEntidad", b =>
                {
                    b.HasOne("GestorPostgreSQL.Shared.Modelos.Empleado", null)
                        .WithMany()
                        .HasForeignKey("empleadoscodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestorPostgreSQL.Shared.Modelos.Entidad", null)
                        .WithMany()
                        .HasForeignKey("entidadescodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
