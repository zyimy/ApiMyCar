using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("modelo")]
    public class Modelo
    {

        [Key]

        [Column("id")]

        public int IdModelo { get; set; }

        [Column("nombre")]

        public String nombre { get; set; }

        [Column("marcaId")]

        public int marca { get; set; }




    }
}
