using Hoteldia.Modelos.DTO;

namespace Hoteldia.Repositorio.IRespositorio
{
    public interface IHabitacionRepositorio
    {
        public Task<HabitacionDTO> CrearHabitacion(HabitacionDTO habitacionDTO);
        public Task<HabitacionDTO> ActualizarHabitacion(int habitacionId, HabitacionDTO habitacionDTO);
        public Task<int> BorrarHabitacion(int habitacionId);
        public Task<HabitacionDTO> GetHabitacion(int habitacionId);
        public Task<IEnumerable<HabitacionDTO>> GetAllHabitaciones(int propiedadId);

    }
}
