using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("chasis")]
    public class Chasi
    {
        [Key]

        [Column("id")]

        public int IdChasis { get; set; }


        [Column("suspension_delantera")]

        public String Suspension_delantera { get; set; }

        [Column("suspension_trasera")]

        public String Suspension_trasera { get; set; }

        [Column("distancia_ejes")]
        public int Distancia_ejes { get; set; }

        [Column("velocidades")]
        public int Velocidades { get; set; }

        [Column("traccion")]
        public String Traccion { get; set; }

        [Column("neumatico_delantero")]
        public String neumatico_delantero { get; set; }

        [Column("neumatico_trasero")]
        public String neumatico_trasero { get; set; }

        [Column("cambio_id")]
        public int Cambio { get; set; }

        [Column("modelo_id")]
        public int Modelo { get; set; }

        [Column("marca_id")]
        public int Marca { get; set; }

        [Column("id_coche")]
        public int Id_coche { get; set; }

    }
}
