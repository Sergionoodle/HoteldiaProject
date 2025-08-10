using Hoteldia.Modelos.DTO;

namespace Hoteldia.Repositorio.IRespositorio
{
    public interface ICountryRepositorio
    {
        public Task<IEnumerable<CountryDTO>> GetAllCountries();

        public Task<CountryDTO> GetCountry(int countryId);

        public Task<IEnumerable<CountryDropDownDTO>> GetDropDownCountry();
    }
}
