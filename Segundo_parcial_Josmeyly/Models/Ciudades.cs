using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Segundo_parcial_Josmeyly.Models
{
    public class Ciudades
    {

        [Key]
        public int CiudadId { get; set; }

        public string Nombres { get; set; } = null!;

        public double Monto { get; set; }

        [InverseProperty("Ciudad")]
        public virtual ICollection<Encuesta> Encuesta { get; set; } = new List<Encuesta>();

        


    }
}

