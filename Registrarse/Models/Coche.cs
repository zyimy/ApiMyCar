using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Models
{
    [Table("coche")]
    public class Coche
    {

        [Key]

        [Column("id")]

        public int IdCoche { get; set; }


        [Column("modelo_Id")]

        public int Modelo { get; set; }

        [Column("marca_Id")]

        public int Marca { get; set; }

        [Column("combustible_Id")]
        public int Combustible { get; set; }

        [Column("puertas")]
        public int Puertas { get; set; }

        [Column("anio")]
        public int Anio { get; set; }

        [Column("pvp")]
        public int Pvp { get; set; }

        [Column("version")]
        public String Version { get; set; }

        [Column("carroceria")]
        public String Carroceria { get; set; }

        [Column("acabado")]
        public String Acabado { get; set; }

        [Column("plazas_homologadas")]
        public int plazasHomologadas { get; set; }

        [Column("image")]
        public String imagenes { get; set; }


        [Column("models")]
        public String modelos { get; set; }

        [Column("combustible")]
        public String combustibles { get; set; }

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

        [Column("emisiones")]
        public int Emisiones { get; set; }

        [Column("consumo_urbano")]
        public String ConsumoUrbano { get; set; }

        [Column("consumo_extraurbano")]
        public String ConsumoExtraUrbano { get; set; }

        [Column("consumo_medio")]
        public String ConsumoMedio { get; set; }

        [Column("capacidad_deposito")]
        public int ConsumoDeposito { get; set; }

        [Column("autonomia_aproximada")]
        public int AutonomiaAproximada { get; set; }

        [Column("velocidad_maxima")]
        public int Velocidad_maxima { get; set; }

        [Column("cilindrada")]
        public int Cilindrada { get; set; }

        [Column("numero_cilindros")]
        public int NumeroCilindros { get; set; }

        [Column("carrera")]
        public int Carrera { get; set; }

        [Column("posiscion_motor")]
        public String PosicionMotor { get; set; }


        [Column("orientacion_motor")]
        public String OrientacionMotor { get; set; }

        [Column("ratio_comprension")]
        public String RatioComprension { get; set; }

        [Column("tipo_admision")]
        public String TipoAdmision { get; set; }

        [Column("numero_valvulas")]
        public int NumeroValvulas { get; set; }

        [Column("compresor")]
        public String Compresor { get; set; }

        [Column("intercooler")]
        public String Intercooler { get; set; }

        [Column("potencia_maxima")]
        public int PotenciaMaxima { get; set; }

        [Column("rpm_potencia_max")]
        public int RpmPotenciaMaxima { get; set; }

        [Column("par_maximo")]
        public int ParMaximo { get; set; }

        [Column("rpm_a_par_maximo")]
        public int RpmAParMaximo { get; set; }


    }
}