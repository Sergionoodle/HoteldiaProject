using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoteldia.Modelos
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(3)]
        public string Code { get; set; }

        //Añadimos la relacion con propiedades
        public virtual ICollection<Propiedad> Propiedades { get; set; }
    }
}
