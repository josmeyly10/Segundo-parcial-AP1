using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Segundo_parcial_Josmeyly.Models
{
    public class DetalleCiudad
    {
        [Key]
        public int DetalleCiudadId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]

        public double MontoCuenta { get; set; }


        [ForeignKey("EncuestaId")]

        
        public virtual Encuesta Encuesta { get; set; } = null!;



    }
}