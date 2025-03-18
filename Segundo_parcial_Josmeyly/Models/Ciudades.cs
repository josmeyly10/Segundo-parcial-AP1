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

        public virtual ICollection<Encuesta> Encuesta { get; set; } = new List<Encuesta>();

        public virtual ICollection<DetalleCiudad> DetalleCiudad { get; set; } = new List<DetalleCiudad>();

    }
}