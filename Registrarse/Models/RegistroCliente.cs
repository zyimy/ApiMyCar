using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("registro_cliente")]
    public class RegistroCliente
    {
        [Key]

        [Column("Id")]

        public int IdRegistro { get; set; }

        [Column("Nombre")]

        public String nombre { get; set; }


        [Column("Apellido")]

        public String apellido { get; set; }

        [Column("telefono")]

        public String Telefono { get; set; }

        [Column("correo_electronico")]

        public String CorreoEletronico { get; set; }

        [Column("contrasena")]
        public String Contrasena { get; set; }

        [Column("calle")]
        public String Calle { get; set; }

        [Column("numero")]
        public String Numero { get; set; }

        [Column("piso")]
        public String Piso { get; set; }
    }
}
