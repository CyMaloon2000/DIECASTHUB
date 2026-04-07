using DiecastHub.DTO.Person.Response;
using DiecastHub.Models;

namespace DiecastHub.Services.IServices
{
    public interface IPersonServices
    {
        Task<List<PersonResponseDTO>> GetAllPersonsAsync();
        Task<PersonResponseDTO?> GetPersonByIdAsync(int id);
        Task<PersonResponseDTO> CreatePersonAsync(PersonResponseDTO person);
        Task<bool> UpdatePersonAsync(int id, PersonResponseDTO person);
        Task<bool> DeletePersonAsync(int id);
    }
}
