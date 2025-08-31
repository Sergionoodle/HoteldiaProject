namespace Hoteldia.Modelos.DTO
{
    public class HabitacionDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public double PrecioPorNoche { get; set; }   
        public int CantidadDisponible { get; set; }  
        public string? Descripcion { get; set; }
        public int PropiedadId { get; set; }
    }
}
