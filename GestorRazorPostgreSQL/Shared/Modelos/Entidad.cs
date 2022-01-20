using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestorPostgreSQL.Shared.Modelos
{
    public class Entidad
    {

        [Key]
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string sector { get; set; }

        [JsonIgnore]
        public List<Empleado> empleados { get; set; }

    }
}
