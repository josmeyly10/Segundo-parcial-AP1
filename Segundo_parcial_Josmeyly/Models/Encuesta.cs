using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Segundo_parcial_Josmeyly.Models
{
    public class Encuesta
    {

        [Key]
        public int EncuestaId { get; set; }


            public DateTime? Fecha { get; set; } = DateTime.Now;

            [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "solo se permiten letras")]
            public string? Asignatura { get; set; }
            
           public double Monto { get; set; }

             
            [InverseProperty("Encuesta")]
            [ForeignKey("CiudadesId")]
            public virtual ICollection<DetalleCiudad> DetalleCiudad { get; set; } = new List<DetalleCiudad>();

            public virtual Ciudades Ciudades { get; set; } = null!;
            public int CiudadesId { get; internal set; }
    }
}
