using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Segundo_parcial_Josmeyly.Models
{
    public class Ciudades
    {

        [Key]
        public int CiudadesId { get; set; }

        public string Nombres { get; set; } = null!;

        public double Monto { get; set; }

        [InverseProperty("Ciudades")]
        public virtual ICollection<Encuesta> Encuesta { get; set; } = new List<Encuesta>();

        [InverseProperty("Ciudades")]

        public virtual ICollection<DetalleCiudad> DetalleCiudad { get; set; } = new List<DetalleCiudad>();
        
    }




}


