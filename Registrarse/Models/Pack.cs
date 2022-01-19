using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("pack")]
    public class Pack
    {
        [Key]

        [Column("Id")]

        public int IdPack { get; set; }

        [Column("decripcion")]

        public String Descripcion { get; set; }


        [Column("imagen")]

        public String Imagen { get; set; }

        [Column("precio")]

        public int Precio { get; set; }
    }
}
