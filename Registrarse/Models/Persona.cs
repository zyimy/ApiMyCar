using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("registro")]
    public class Persona
    {

        [Key]

        [Column("id")]

        public int IdPersona { get; set; }

        [Column("nombre")]

        public String Nombre { get; set; }

        [Column("correo_electronico")]

        public String CorreoEletronico { get; set; }

        [Column("contrasena")]
        public String Contrasena { get; set; }
    }
}
