using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoteldia.Modelos
{
    public class Reserva
    {

        [Key]
        public int Id { get; set; } 

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        [Required]
        public int CantidadHabitaciones { get; set; }

        public bool Pagado { get; set; } = false;

        //Relacion con el hotel
        public int PropiedadId { get; set; }
        [ForeignKey("PropiedadId")]
        public virtual Propiedad Propiedad { get; set; }

        //Relacion con la habitacion
        public int HabitacionId { get; set; }
        [ForeignKey("HabitacionId")]
        public virtual Habitacion Habitacion { get; set; }
        // Email de la persona que reserva
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
