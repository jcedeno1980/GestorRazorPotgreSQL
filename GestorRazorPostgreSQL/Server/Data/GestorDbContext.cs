using GestorPostgreSQL.Shared.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorPostgreSQL.Server.Data
{
    public class GestorDbContext : DbContext
    {
        public GestorDbContext(DbContextOptions<GestorDbContext> options) : base(options)
        {

        }

        //Referenciamos los modelos que vaya a utilizar Entity Framework. 
        public virtual DbSet<Entidad> Entidades { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }

    }
}
