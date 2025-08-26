namespace Hoteldia.Modelos.DTO
{
    public class HabitacionDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal PrecioPorNoche { get; set; }
        public int Capacidad { get; set; }
        public string? Descripcion { get; set; }
        public bool Activa { get; set; }
        public int PropiedadId { get; set; }
    }
}
