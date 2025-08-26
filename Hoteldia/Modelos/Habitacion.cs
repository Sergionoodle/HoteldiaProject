using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoteldia.Modelos
{
    public class Habitacion
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        [Range(1, 50)]
        public int CantidadDisponible { get; set; }

        [Required]
        public double PrecioPorNoche { get; set; }

        //Creamos la relacion con el hotel 
        public int PropiedadId { get; set; }
        [ForeignKey("PropiedadId")]
        public virtual Propiedad Propiedad { get; set; }
    }
}
