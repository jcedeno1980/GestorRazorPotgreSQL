using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestorPostgreSQL.Shared.Modelos
{
    public class Empleado
    {
        [Key]
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string estudios { get; set; }
        public DateTime fechanacimiento { get; set; }

        //[JsonIgnore]
        public List<Entidad> entidades { get; set; }

    }
}
