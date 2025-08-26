
using AutoMapper;
using Hoteldia.Data;
using Hoteldia.Modelos;
using Hoteldia.Modelos.DTO;
using Hoteldia.Repositorio.IRespositorio;
using Microsoft.EntityFrameworkCore;

namespace Hoteldia.Repositorio
{
    public class HabitacionRepositorio : IHabitacionRepositorio
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HabitacionRepositorio(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<HabitacionDTO> ActualizarHabitacion(int habitacionId, HabitacionDTO habitacionDTO)
        {
            if (habitacionId != habitacionDTO.Id)
            {
                return null;
            }

            var habitacion = await _db.Habitacion.FindAsync(habitacionId);
            if (habitacion == null)
            {
                return null;
            }

            _mapper.Map(habitacionDTO, habitacion);
            _db.Habitacion.Update(habitacion);
            await _db.SaveChangesAsync();

            return _mapper.Map<Habitacion, HabitacionDTO>(habitacion);

        }

        public async Task<int> BorrarHabitacion(int habitacionId)
        {
            var habitacion = await _db.Habitacion.FindAsync(habitacionId);
            if (habitacion == null)
            {
                return 0;
            }

            _db.Habitacion.Remove(habitacion);
            return await _db.SaveChangesAsync();
        }

        public async Task<HabitacionDTO> CrearHabitacion(HabitacionDTO habitacionDTO)
        {
            Habitacion habitacion = _mapper.Map<HabitacionDTO, Habitacion>(habitacionDTO);
            var habitacionAgregada = await _db.Habitacion.AddAsync(habitacion);
            await _db.SaveChangesAsync();
            return _mapper.Map<Habitacion, HabitacionDTO>(habitacionAgregada.Entity);
        }

        public async Task<IEnumerable<HabitacionDTO>> GetAllHabitaciones(int propiedadId)
        {
            var habitaciones = await _db.Habitacion
                                        .Where(h => h.PropiedadId == propiedadId)
                                        .ToListAsync();
            return _mapper.Map<IEnumerable<Habitacion>, IEnumerable<HabitacionDTO>>(habitaciones);

        }

        public async Task<HabitacionDTO> GetHabitacion(int habitacionId)
        {
            var habitacion = await _db.Habitacion.Include(h => h.Propiedad)
                                                 .FirstOrDefaultAsync(h => h.Id == habitacionId);
            return _mapper.Map<Habitacion, HabitacionDTO>(habitacion);
        }
    }
}
