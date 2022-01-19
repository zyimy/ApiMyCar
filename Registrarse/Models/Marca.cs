using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{

    [Table("marca")]
    public class Marca
    {

        [Key]

        [Column("id")]

        public int Idmarca { get; set; }

        

        [Column("nombre")]

        public String nombre { get; set; }

        

        [Column("imagen")]

        public String imagen { get; set; }
    }
}
