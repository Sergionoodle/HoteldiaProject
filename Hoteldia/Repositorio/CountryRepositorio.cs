using AutoMapper;
using Hoteldia.Data;
using Hoteldia.Modelos;
using Hoteldia.Modelos.DTO;
using Hoteldia.Repositorio.IRespositorio;
using Microsoft.EntityFrameworkCore;

namespace Hoteldia.Repositorio
{
    public class CountryRepositorio : ICountryRepositorio
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CountryRepositorio(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
       
        public async Task<IEnumerable<CountryDTO>> GetAllCountries()
        {
            try
            {
                IEnumerable<CountryDTO> countryDTO = _mapper.Map<IEnumerable<Country>, IEnumerable<CountryDTO>>(_db.Country);
                return (countryDTO);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CountryDTO> GetCountry(int countryId)
        {
            try
            {
                CountryDTO countryDTO =
                    _mapper.Map<Country, CountryDTO>(await _db.Country.FirstOrDefaultAsync(c => c.Id == countryId));
                return (countryDTO);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<CountryDropDownDTO>> GetDropDownCountry()
        {
            try
            {
                IEnumerable<CountryDropDownDTO> dropDownDTO = _mapper.Map<IEnumerable<Country>, IEnumerable<CountryDropDownDTO>>(_db.Country);
                return (dropDownDTO);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
