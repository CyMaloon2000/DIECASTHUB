using DiecastHub.DTO.Person.Request;
using DiecastHub.DTO.Person.Response;
using DiecastHub.Models;

namespace DiecastHub.Services.IServices
{
    public interface IPersonServices
    {
        Task<List<PersonResponseDTO>> GetAllPersonsAsync();
        Task<PersonResponseDTO?> GetPersonByIdAsync(int id);
        Task<PersonResponseDTO> AddPersonAsync(PersonCreateDTO person);
        Task<bool> UpdatePersonAsync(int id, PersonUpdateDTO person);
        Task<bool> DeletePersonAsync(int id);
    }
}
