using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("restaurante")]
    public class Restaurante
    {
        [Key]

        [Column("Id")]

        public int IdRestaurante { get; set; }

        [Column("nombre")]

        public String nombre { get; set; }


        [Column("telefono")]

        public String Telefono { get; set; }


        [Column("horario")]

        public String Horario { get; set; }

        [Column("nombre_calle")]
        public String NombreCalle { get; set; }

        [Column("numero_calle")]
        public String NumeroCalle { get; set; }

        [Column("descripcion")]
        public String Descripcion { get; set; }

        [Column("imagen")]
        public String Imagen { get; set; }
    }
}
