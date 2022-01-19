using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    public class Imagen
    {

        [Key]

        [Column("id")]

        public int Idimagen { get; set; }

        [Column("imagen")]

        public String imagen { get; set; }

        [Column("version")]

        public String version { get; set; }

    }
}
